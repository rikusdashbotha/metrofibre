using Microsoft.EntityFrameworkCore;

using MetroFibre.Core.Entities;
using MetroFibre.Data.Contexts;
using MetroFibre.Data.Interfaces;

namespace MetroFibre.Data.Repositories;

public class IngredientRepository : BaseRepository<IngredientEntity>, IIngredientRepository
{
    public IngredientRepository(FoodDbContext context)
        : base(context)
    {
    }

    public async Task<List<IngredientEntity>?> GetIngredients()
    {
        return await base._context.Ingredients
            .ToListAsync() ?? null;
    }
}