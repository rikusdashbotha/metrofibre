using Microsoft.EntityFrameworkCore;

using MetroFibre.Core.Entities;
using MetroFibre.Data.Seeds;

namespace MetroFibre.Data.Contexts;

public class FoodDbContext : DbContext
{
    #region Properties

    public DbSet<IngredientEntity> Ingredients { get; set; } = null!;
    public DbSet<RecipeEntity> Recipes { get; set; } = null!;
    public DbSet<RecipeIngredientEntity> RecipeIngredients { get; set; } = null!;

    #endregion Properties

    public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //NOTE: Use this to migrate if needed.
        //optionsBuilder.UseSqlServer("server=.\\MSSQLSERVER01;Database=FoodDb;Trusted_Connection=True;Encrypt=false;");
    }

    public FoodDbContext() { }

    #region Public Methods

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<RecipeEntity>(o =>
        {
            o.Property(c => c.Name).HasColumnType("varchar(80)");

            o.HasMany(c => c.RecipeIngredients)
            .WithOne(c => c.Recipe);

        });

        builder.Entity<IngredientEntity>(o =>
        {
            o.Property(c => c.Name).HasColumnType("varchar(80)");

            o.HasMany(c => c.RecipeIngredients)
            .WithOne(c => c.Ingredient);
        });

        SeedData(builder);
    }

    #endregion Public Methods

    #region Private Methods

    private void SeedData(ModelBuilder builder) 
    {
        IngredientSeed.SeedIngredient(builder);
        RecipeSeed.SeedRecipe(builder);
        RecipeIngredientSeed.SeedRecipeIngredient(builder);
    }

    #endregion Private Methods
}