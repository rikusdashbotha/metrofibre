using MetroFibre.Core.Dtos;
using MetroFibre.Core.Extensions;
using MetroFibre.Data.Interfaces;
using MetroFibre.Service.Interfaces;

namespace MetroFibre.Service.Services;

public class RecipeService : IRecipeService
{
    #region Fields

    private readonly IRecipeRepository recipeRepository;
    private readonly IRecipeIngredientRepository recipeIngredientRepository;
    private readonly IIngredientRepository ingredientRepository;

    #endregion Fields

    public RecipeService(
        IRecipeRepository recipeRepository,
        IRecipeIngredientRepository recipeIngredientRepository,
        IIngredientRepository ingredientRepository)
    {
        this.recipeRepository = recipeRepository;
        this.recipeIngredientRepository = recipeIngredientRepository;
        this.ingredientRepository = ingredientRepository;
    }

    #region Public Methods

    public async Task BestCombinationOfRecipes()
    {
        try
        {
            Console.WriteLine($"Please ensure you have the database setup and seeded. Set 'MetroFibre.Data' as the default project, and MetroFibre as the start-up project - and run 'update-database' in the PMC.");
            Console.WriteLine($"Ready? Let's feed ALL the people.{Environment.NewLine}");
            Console.Read();            
            Console.Write($"Retrieving Data & Setting Up...");

            //Pull recipes
            var recipeList = await recipeRepository.GetRecipes();

            if (recipeList is null)
                throw new Exception("No Recipes Found.");

            var ingredientList = ((await ingredientRepository.GetIngredients()) ?? throw new Exception("No Ingredients Found.")).ToDtoList();
            var recipeDtoList = recipeList.ToDtoList();

            /*
             * Lists are generally used here since multiple iterations are used to process the data.
             */

            var possibleRecipeCombinations = GetPowerSet(recipeDtoList).Select(subset => subset.Select(c => c).ToList());

            Console.Write($"Done.{Environment.NewLine}{Environment.NewLine}");
            Console.Write($"Use Alternative Permutation Result-Set? (Uses more resources) (y/N): ");
            var keyPressed = Console.ReadKey();

            if (keyPressed.Key == ConsoleKey.Y)
            {
                possibleRecipeCombinations = GetCombinationPermutations(recipeDtoList, 4); //No feasible recipe combo will yield >= 4 units.
                var innerCounter = 1;

                //Write out permutation of combo
                foreach (var perm in possibleRecipeCombinations)
                {
                    Console.WriteLine($"[{innerCounter++}] Recipe(s) {string.Join(", ", perm.Select(recipe => recipe.Name))}");
                }
            }

            var recipeDictionaryResult = new Dictionary<string, int>();
            var counter = 1;            

            foreach (var recipeCombination in possibleRecipeCombinations)
            {
                if (recipeCombination is null || recipeCombination.Count == 0)
                    continue;

                //Gets the yield from all recipe combos we send in. Pass by value, not reference.
                var (recipeNames, feedYield) = HighestYieldPerRecipe(
                    recipeCombination.Select(c => c.Copy()).ToList(), 
                    ingredientList.Select(c => c.Copy()).ToList());

                recipeDictionaryResult.Add(recipeNames, feedYield);
                Console.WriteLine($"[{counter++}] Recipe(s) {recipeNames} will feed [{feedYield}] people.");
            }

            var optimalRecipe = recipeDictionaryResult.MaxBy(c => c.Value);
            Console.WriteLine($"{Environment.NewLine}Optimal Combination: {optimalRecipe.Key} which will feed [{optimalRecipe.Value}] people.{Environment.NewLine}");
            Console.WriteLine($"PS. Still think the best combo actually feeds 13 people. It's the above recipe + 1 x Sandwich.{Environment.NewLine}");

            Console.WriteLine("For your consideration. Happy to explain the steps taken to determine the result.");
            Console.ReadLine();
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Exception thrown: {exception.Message}");
        }

        Console.ReadLine();
    }

    /// <summary>
    /// Given a set of ingredients and recipes, determines which recipe combination will yield the most people fed.
    /// </summary>
    /// <param name="recipes">Supplied combination of recipes.</param>
    /// <param name="ingredients">Available resources to make 1 of each recipe with.</param>
    /// <returns>A formatted string the recipe name combination and people fed.</returns>
    public (string, int) HighestYieldPerRecipe(
        List<RecipeDto> recipes,
        List<IngredientDto> ingredients)
    {
        bool isSingleRecipe = recipes.Count == 1 ? true : false;

        foreach (var recipe in recipes)
        {
            recipe.DetermineYield(ingredients, isSingleRecipe);
            //This works, but it assumes we're only making one recipe of each (to preserve ingredients). What about checking the remainder of ingredients for a viable recipe?
        }

        return new(string.Join(", ", recipes.Select(c => $"{c.Name}")), recipes.Sum(c => c.FeedYield));
    }

    #endregion Public Methods

    #region Private Methods

    private IEnumerable<IEnumerable<T>> GetPowerSet<T>(List<T> list)
    {
        return from m in Enumerable.Range(0, 1 << list.Count)
               select
                   from i in Enumerable.Range(0, list.Count)
                   where (m & (1 << i)) != 0
                   select list[i];
    }

    private IEnumerable<List<T>> GetCombinationPermutations<T>(List<T> list, int maxRepeat)
    {
        var results = new List<List<T>>();

        void BuildCombinations(List<T> currentCombination, int index)
        {
            if (index == list.Count)
            {
                results.Add(new List<T>(currentCombination));

                return;
            }

            //Loop through the recipe combo
            for (int count = 0; count <= maxRepeat; count++)
            {
                for (int i = 0; i < count; i++)
                {
                    currentCombination.Add(list[index]);
                }

                // Recursively build combinations with the rest of the recipes
                BuildCombinations(currentCombination, index + 1);

                // Remove the added recipes to backtrack for the next combination
                currentCombination.RemoveRange(currentCombination.Count - count, count);
            }
        }

        // Start the recursive process
        BuildCombinations(new List<T>(), 0);

        return results;
    }

    #endregion Private Methods
}