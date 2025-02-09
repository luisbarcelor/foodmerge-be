using System.ComponentModel.DataAnnotations;

namespace FoodMerge.Domain.Entities;

public class IngredientCategory
{
    [Key]
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string? Name { get; set; }
}
