using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MetroFibre.Data.Contexts;
using MetroFibre.Data.Interfaces;
using MetroFibre.Data.Repositories;
using MetroFibre.Service.Interfaces;
using MetroFibre.Service.Services;

namespace MetroFibre;

internal class Program
{

    static async Task Main(string[] args)
    {
        var services = CreateServices();
        var recipeService = services.GetRequiredService<IRecipeService>();

        await recipeService.BestCombinationOfRecipes();
    }

    private static IServiceProvider CreateServices()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var serviceProvider = new ServiceCollection()
            .AddDbContext<FoodDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("FoodDbConnection"));
                options.EnableDetailedErrors();
            })
            .AddScoped<IRecipeRepository, RecipeRepository>()
            .AddScoped<IRecipeIngredientRepository, RecipeIngredientRepository>()
            .AddScoped<IIngredientRepository, IngredientRepository>()
            .AddScoped<IRecipeService, RecipeService>()
            .BuildServiceProvider();

        return serviceProvider;
    }
}