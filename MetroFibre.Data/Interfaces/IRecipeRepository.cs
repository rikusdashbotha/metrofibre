using MetroFibre.Core.Entities;

namespace MetroFibre.Data.Interfaces;

public interface IRecipeRepository
{
    Task<List<RecipeEntity>?> GetRecipes();
}