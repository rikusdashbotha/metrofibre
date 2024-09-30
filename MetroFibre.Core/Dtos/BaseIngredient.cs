namespace MetroFibre.Core.Dtos;

public abstract class BaseIngredient
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
}