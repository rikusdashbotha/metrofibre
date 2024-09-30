using Microsoft.EntityFrameworkCore;

using MetroFibre.Core.Constants;
using MetroFibre.Core.Entities;

namespace MetroFibre.Data.Seeds;

public static class IngredientSeed
{
    public static void SeedIngredient(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IngredientEntity>().HasData(new List<IngredientEntity>()
        {
            new IngredientEntity()
            {
                Id = IngredientConstants.Meat,
                Name = "Meat",
                Quantity = 6
            },
            new IngredientEntity()
            {
                Id = IngredientConstants.Lettuce,
                Name = "Lettuce",
                Quantity = 3
            },
            new IngredientEntity()
            {
                Id = IngredientConstants.Tomato,
                Name = "Tomato",
                Quantity = 6
            },
            new IngredientEntity()
            {
                Id = IngredientConstants.Cheese,
                Name = "Cheese",
                Quantity = 8
            },
            new IngredientEntity()
            {
                Id = IngredientConstants.Dough,
                Name = "Dough",
                Quantity = 10
            },
            new IngredientEntity()
            {
                Id = IngredientConstants.Cucumber,
                Name = "Cucumber",
                Quantity = 2
            },
            new IngredientEntity()
            {
                Id = IngredientConstants.Olives,
                Name = "Olives",
                Quantity = 2
            },
        });
    }
}