using MetroFibre.Core.Entities;

namespace MetroFibre.Core.Dtos;

public class IngredientDto : BaseIngredient
{
    public int AmountAvailable { get; set; }

    public IngredientDto Copy()
    {
        return new IngredientDto
        {
            Id = Id,
            Name = Name,
            AmountAvailable = AmountAvailable,
        };
    }

    #region Implicit Operators

    public static implicit operator IngredientDto(IngredientEntity entity)
    {
        return new IngredientDto
        {
            Id = entity.Id,
            Name = entity.Name,
            AmountAvailable = entity.Quantity
        };
    }

    #endregion Implicit Operators
}