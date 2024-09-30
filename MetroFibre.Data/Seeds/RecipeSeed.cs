using Microsoft.EntityFrameworkCore;

using MetroFibre.Core.Constants;
using MetroFibre.Core.Entities;

namespace MetroFibre.Data.Seeds;

public static class RecipeSeed
{
    public static void SeedRecipe(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeEntity>().HasData(new List<RecipeEntity>()
        {
            new RecipeEntity()
            {
                Id = RecipeConstants.Burger,
                Name = "Burger",
                Feeds = 1
            },
            new RecipeEntity()
            {
                Id = RecipeConstants.Pasta,
                Name = "Pasta",
                Feeds = 2
            },
            new RecipeEntity()
            {
                Id = RecipeConstants.Pie,
                Name = "Pie",
                Feeds = 1
            },
            new RecipeEntity()
            {
                Id = RecipeConstants.Salad,
                Name = "Salad",
                Feeds = 3
            },
            new RecipeEntity()
            {
                Id = RecipeConstants.Sandwich,
                Name = "Sandwich",
                Feeds = 1
            },
            new RecipeEntity()
            {
                Id = RecipeConstants.Pizza,
                Name = "Pizza",
                Feeds = 4
            },
        });
    }
}