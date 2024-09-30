using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MetroFibre.Data.Contexts;
using MetroFibre.Data.Interfaces;
using MetroFibre.Data.Repositories;
using MetroFibre.Service.Services;
using MetroFibre.Service.Interfaces;

namespace MetroFibre;

internal class Program
{
    private const string Assembly = "MetroFibre.Data";

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

        //serviceProvider.SetupContexts(configuration);

        return serviceProvider;
    }
}