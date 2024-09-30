using MetroFibre.Core.Entities;
using MetroFibre.Core.Extensions;

namespace MetroFibre.Core.Dtos;

public class RecipeDto
{
    #region Properties

    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<RecipeIngredientDto>? RecipeIngredients { get; set; } = null!;
    public int RecipeYield { get; set; }
    public int Feeds { get; set; }
    public int FeedYield { get { return RecipeYield * Feeds; } private set { } }

    #endregion Properties

    #region Public Methods

    /// <summary>
    /// Given some ingredients, determines how many times this recipe can be made.
    /// </summary>
    /// <param name="availableIngredients">The ingredients which will be consumed by this recipe.</param>
    public void DetermineYield(List<IngredientDto> availableIngredients, bool useAllIngredients = false)
    {
        while (CanProduceRecipe(availableIngredients))
        {
            RecipeYield++;

            if (!useAllIngredients)
                break;
        }
    }

    /// <summary>
    /// Provides a Deep Copy of the instance.
    /// </summary>
    /// <returns>A Deep(i.e. true) Copy of the instance.</returns>
    public RecipeDto Copy()
    {
        return new RecipeDto
        {
            Id = Id,
            Name = Name,
            Feeds = Feeds,
            FeedYield = FeedYield,
            RecipeIngredients = RecipeIngredients,
            RecipeYield = RecipeYield
        };
    }

    #endregion Public Methods

    #region Private Methods

    /// <summary>
    /// Builds out the recipe as long as enough ingredients are supplied.
    /// Deducts the consumed resources.
    /// </summary>
    /// <param name="availableIngredients">The ingredients which will be consumed by this recipe.</param>
    /// <returns>Returns True if this recipe could indeed be created. </returns>
    private bool CanProduceRecipe(List<IngredientDto> availableIngredients)
    {
        if (RecipeIngredients is null || RecipeIngredients.Count == 0)
            return false;

        foreach (var recipeIngredient in RecipeIngredients)
        {
            //Find matching available ingredient
            var selectedIngredient = availableIngredients.FirstOrDefault(c => c.Id == recipeIngredient.IngredientId);

            if (selectedIngredient is null 
                || selectedIngredient.AmountAvailable <= 0 
                || selectedIngredient.AmountAvailable < recipeIngredient.RequiredAmount)
            {
                //Ingredient and/or quantity of ingredient unavailable
                //TODO hang on! So you've built a recipe and at 99% you run out of ingredients. Those are consumed and ought to be reversed if we consider the whole "what's left" scenario
                return false; 
            }

            selectedIngredient.AmountAvailable -= recipeIngredient.RequiredAmount;
        }        

        return true;
    }

    #endregion Private Methods

    #region Implicit Operators

    public static implicit operator RecipeDto(RecipeEntity entity)
    {
        return new RecipeDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Feeds = entity.Feeds,
            RecipeIngredients = entity.RecipeIngredients.ToDtoList()
        };
    }

    #endregion Implicit Operators
}