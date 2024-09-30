using Microsoft.EntityFrameworkCore;

using MetroFibre.Data.Contexts;
using MetroFibre.Core.Entities;
using MetroFibre.Data.Interfaces;

namespace MetroFibre.Data.Repositories;

public class RecipeRepository : BaseRepository<RecipeEntity>, IRecipeRepository
{
    public RecipeRepository(FoodDbContext context)
        : base(context)
    {
    }

    public async Task<List<RecipeEntity>?> GetRecipes()
    {
        return await base._context.Recipes
            .Include(c => c.RecipeIngredients)
            .ToListAsync() ?? null;
    }
}