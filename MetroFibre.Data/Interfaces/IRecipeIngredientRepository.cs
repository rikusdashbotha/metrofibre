using MetroFibre.Core.Entities;

namespace MetroFibre.Data.Interfaces;

public interface IRecipeIngredientRepository
{
    Task<List<RecipeIngredientEntity>?> GetRecipeIngredients();
}