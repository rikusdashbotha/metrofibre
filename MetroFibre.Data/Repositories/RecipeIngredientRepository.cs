using Microsoft.EntityFrameworkCore;

using MetroFibre.Data.Contexts;
using MetroFibre.Core.Entities;
using MetroFibre.Data.Interfaces;

namespace MetroFibre.Data.Repositories;

public class RecipeIngredientRepository : BaseRepository<RecipeIngredientEntity>, IRecipeIngredientRepository
{
    public RecipeIngredientRepository(FoodDbContext context)
        : base(context)
    {
    }

    public async Task<List<RecipeIngredientEntity>?> GetRecipeIngredients()
    {
        return await base._context.RecipeIngredients
            .Include(c => c.Recipe)
            .ToListAsync() ?? null;
    }
}