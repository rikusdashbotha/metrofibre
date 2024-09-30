using MetroFibre.Core.Constants;
using MetroFibre.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetroFibre.Data.Seeds;

public static class RecipeIngredientSeed
{
    public static void SeedRecipeIngredient(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeIngredientEntity>().HasData(new List<RecipeIngredientEntity>()
        {
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002000"),
                RecipeId = RecipeConstants.Burger,
                IngredientId = IngredientConstants.Meat,
                RequiredAmount = 1,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002001"),
                RecipeId = RecipeConstants.Burger,
                IngredientId = IngredientConstants.Lettuce,
                RequiredAmount = 1,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002002"),
                RecipeId = RecipeConstants.Burger,
                IngredientId = IngredientConstants.Tomato,
                RequiredAmount = 1,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002003"),
                RecipeId = RecipeConstants.Burger,
                IngredientId = IngredientConstants.Cheese,
                RequiredAmount = 1,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002004"),
                RecipeId = RecipeConstants.Burger,
                IngredientId = IngredientConstants.Dough,
                RequiredAmount = 1,
            },
        });

        modelBuilder.Entity<RecipeIngredientEntity>().HasData(new List<RecipeIngredientEntity>()
        {
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002005"),
                RecipeId = RecipeConstants.Pasta,
                IngredientId = IngredientConstants.Dough,
                RequiredAmount = 2,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002006"),
                RecipeId = RecipeConstants.Pasta,
                IngredientId = IngredientConstants.Tomato,
                RequiredAmount = 1,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002007"),
                RecipeId = RecipeConstants.Pasta,
                IngredientId = IngredientConstants.Cheese,
                RequiredAmount = 2,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002008"),
                RecipeId = RecipeConstants.Pasta,
                IngredientId = IngredientConstants.Meat,
                RequiredAmount = 1,
            },
        });

        modelBuilder.Entity<RecipeIngredientEntity>().HasData(new List<RecipeIngredientEntity>()
        {
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002009"),
                RecipeId = RecipeConstants.Pie,
                IngredientId = IngredientConstants.Dough,
                RequiredAmount = 2,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002010"),
                RecipeId = RecipeConstants.Pie,
                IngredientId = IngredientConstants.Meat,
                RequiredAmount = 2,
            }
        });

        modelBuilder.Entity<RecipeIngredientEntity>().HasData(new List<RecipeIngredientEntity>()
        {
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002011"),
                RecipeId = RecipeConstants.Salad,
                IngredientId = IngredientConstants.Lettuce,
                RequiredAmount = 2,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002012"),
                RecipeId = RecipeConstants.Salad,
                IngredientId = IngredientConstants.Tomato,
                RequiredAmount = 2,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002013"),
                RecipeId = RecipeConstants.Salad,
                IngredientId = IngredientConstants.Cucumber,
                RequiredAmount = 1,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002014"),
                RecipeId = RecipeConstants.Salad,
                IngredientId = IngredientConstants.Cheese,
                RequiredAmount = 2,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002015"),
                RecipeId = RecipeConstants.Salad,
                IngredientId = IngredientConstants.Olives,
                RequiredAmount = 1,
            }
        });

        modelBuilder.Entity<RecipeIngredientEntity>().HasData(new List<RecipeIngredientEntity>()
        {
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002016"),
                RecipeId = RecipeConstants.Sandwich,
                IngredientId = IngredientConstants.Dough,
                RequiredAmount = 1,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002017"),
                RecipeId = RecipeConstants.Sandwich,
                IngredientId = IngredientConstants.Cucumber,
                RequiredAmount = 1,
            }
        });


        modelBuilder.Entity<RecipeIngredientEntity>().HasData(new List<RecipeIngredientEntity>()
        {
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002018"),
                RecipeId = RecipeConstants.Pizza,
                IngredientId = IngredientConstants.Dough,
                RequiredAmount = 3,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002019"),
                RecipeId = RecipeConstants.Pizza,
                IngredientId = IngredientConstants.Tomato,
                RequiredAmount = 2,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002020"),
                RecipeId = RecipeConstants.Pizza,
                IngredientId = IngredientConstants.Cheese,
                RequiredAmount = 3,
            },
            new RecipeIngredientEntity()
            {
                Id = new Guid("00000000-da7a-0000-0000-000000002021"),
                RecipeId = RecipeConstants.Pizza,
                IngredientId = IngredientConstants.Olives,
                RequiredAmount = 1,
            }
        });
    }
}