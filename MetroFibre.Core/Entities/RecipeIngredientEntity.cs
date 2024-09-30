namespace MetroFibre.Core.Entities;

public sealed class RecipeIngredientEntity
{
    public Guid Id { get; set; }
    public Guid RecipeId { get; set; }
    public Guid IngredientId { get; set; }
    public int RequiredAmount { get; set; }

    public RecipeEntity Recipe { get; set; } = null!;
    public IngredientEntity Ingredient { get; set; } = null!;
}