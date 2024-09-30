using MetroFibre.Core.Dtos;
using MetroFibre.Core.Entities;

namespace MetroFibre.Core.Extensions;

public static class RecipeExtensions
{
    public static List<RecipeIngredientDto> ToDtoList(this IEnumerable<RecipeIngredientEntity> entityList)
    {
        return entityList.Select(c => (RecipeIngredientDto)c).ToList();
    }

    public static List<RecipeDto> ToDtoList(this List<RecipeEntity> entityList)
    {
        return entityList.Select(c => (RecipeDto)c).ToList();
    }

    public static List<IngredientDto> ToDtoList(this List<IngredientEntity> entityList)
    {
        return entityList.Select(c => (IngredientDto)c).ToList();
    }
}