using MetroFibre.Core.Entities;

namespace MetroFibre.Core.Dtos;

public sealed class RecipeIngredientDto()// : BaseIngredient //Consider not using base Ingredient. SOLID violation on Name
{
    public Guid Id { get; set; }
    public Guid RecipeId { get; set; }
    public Guid IngredientId { get; set; }
    public int RequiredAmount { get; set; } //{ get { return base.Quantity; } set { } }

    #region Implicit Operators

    public static implicit operator RecipeIngredientDto(RecipeIngredientEntity entity)
    {
        return new RecipeIngredientDto
        {
            Id = entity.Id,
            RecipeId = entity.RecipeId,
            IngredientId = entity.IngredientId,
            RequiredAmount = entity.RequiredAmount
        };
    }

    #endregion Implicit Operators
}