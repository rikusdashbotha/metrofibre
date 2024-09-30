using System.Text;

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
            Console.Write($"Retrieving Data & Setting Up...");

            //Pull recipies
            var recipeList = await recipeRepository.GetRecipes();

            if (recipeList is null)
                throw new Exception("No Recipes Found.");

            //Pull ingredient store (with quantities)
            var ingredientList = (await ingredientRepository.GetIngredients()).ToDtoList();


            if (ingredientList is null)
                throw new Exception("No Ingredients Found.");

            var recipeIngredients = (await recipeIngredientRepository.GetRecipeIngredients()).ToDtoList();

            if (recipeIngredients is null)
                throw new Exception("Recipe Ingredients Not Found.");

            var recipeDtoList = recipeList.ToDtoList();            
            var possibleRecipeCombinations = GetPowerSet(recipeDtoList).Select(subset => subset.Select(c => c).ToList());
            var recipeDictionary = new Dictionary<string, int>();
            var counter = 1;
            Console.Write($"Done.{Environment.NewLine}{Environment.NewLine}");

            foreach (var recipeCombination in possibleRecipeCombinations)
            {
                if (recipeCombination is null || recipeCombination.Count == 0)
                    continue;

                //Gets the yield from all recipe combos we send in.
                var (recipeNames, feedYield) = HighestYieldPerRecipe(
                    recipeCombination.Select(c => c.Copy()).ToList(),
                    ingredientList.Select(c => c.Copy()).ToList());

                recipeDictionary.Add(recipeNames, feedYield);
                Console.WriteLine($"[{counter++}] Recipe(s) {recipeNames} will feed [{feedYield}] people.");
            }

            var optimalRecipe = recipeDictionary.MaxBy(c => c.Value);
            Console.WriteLine($"{Environment.NewLine}Optimal Combination: {optimalRecipe.Key} which will feed [{optimalRecipe.Value}] people.");            
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        Console.ReadLine();
    }

    /// <summary>
    /// Given a set of ingredients and recipes, determines which recipe combination will yield the most people fed.
    /// </summary>
    /// <param name="recipes">Supplied combination of recipes.</param>
    /// <param name="ingredients">Available resources to make 1 of each recipe with.</param>
    /// <param name="recipeIngredients"></param>
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

    #endregion Private Methods
}