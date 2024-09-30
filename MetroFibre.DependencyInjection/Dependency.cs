using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MetroFibre.Data.Contexts;

namespace MetroFibre.DependencyInjection;

public static class Dependency
{
    public const string Assembly = "MetroFibre.Data";

    public static IServiceCollection SetupContexts(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<FoodDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("FoodDbConnection"), b => b.MigrationsAssembly(Assembly));
        });

        return services;
    }
}