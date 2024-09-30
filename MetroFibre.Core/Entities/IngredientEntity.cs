using MetroFibre.Core.Bases;

namespace MetroFibre.Core.Entities;

public sealed class IngredientEntity : BaseIngredient
{
    public List<RecipeIngredientEntity> RecipeIngredients { get; set; } = null!;
}