namespace MetroFibre.Core.Entities;

public sealed class RecipeEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public int Feeds { get; set; }

    public List<RecipeIngredientEntity> RecipeIngredients { get; set; } = null!;
}