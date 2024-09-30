namespace MetroFibre.Core.Entities;

public sealed class IngredientEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public int Quantity { get; set; }

    public List<RecipeIngredientEntity> RecipeIngredients { get; set; } = null!;
}