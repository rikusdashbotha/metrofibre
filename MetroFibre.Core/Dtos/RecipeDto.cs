using MetroFibre.Core.Entities;
using MetroFibre.Core.Extensions;

namespace MetroFibre.Core.Dtos;

public class RecipeDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<RecipeIngredientDto>? RecipeIngredients { get; set; } = null!;
    public int RecipeYield { get; set; }
    public int Feeds { get; set; }
    public int FeedYield { get { return RecipeYield * Feeds; } private set { } }

    #region Public Methods

    /// <summary>
    /// Given some ingredients, determines how many times this recipe can be made.
    /// </summary>
    /// <param name="availableIngredients"></param>
    public void DetermineYield(List<IngredientDto> availableIngredients, bool useAllIngredients = false)
    {
        while (CanProduceRecipe(availableIngredients))
        {
            RecipeYield++;

            if (!useAllIngredients)
                break;
        }
    }

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

    private bool CanProduceRecipe(List<IngredientDto> availableIngredients)
    {
        foreach (var recipeIngredient in RecipeIngredients)
        {
            //Find matching available ingredient
            var selectedIngredient = availableIngredients.FirstOrDefault(c => c.Id == recipeIngredient.IngredientId);

            if (selectedIngredient is null 
                || selectedIngredient.AmountAvailable <= 0 
                || selectedIngredient.AmountAvailable < recipeIngredient.RequiredAmount)
            {
                //Ingredient and/or quantity of ingredient unavailable
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