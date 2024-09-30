using MetroFibre.Core.Entities;

namespace MetroFibre.Data.Interfaces;

public interface IIngredientRepository
{
    Task<List<IngredientEntity>?> GetIngredients();
}