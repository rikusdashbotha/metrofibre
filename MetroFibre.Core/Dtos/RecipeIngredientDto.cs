using MetroFibre.Core.Entities;

namespace MetroFibre.Core.Dtos;

public sealed class RecipeIngredientDto()
{
    public Guid Id { get; set; }
    public Guid RecipeId { get; set; }
    public Guid IngredientId { get; set; }
    public int RequiredAmount { get; set; }

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