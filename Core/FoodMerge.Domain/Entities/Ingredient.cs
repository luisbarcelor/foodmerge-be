using System.ComponentModel.DataAnnotations;

namespace FoodMerge.Domain.Entities;

public class Ingredient
{
    [Key]
    public Guid Id { get; private set; } = Guid.NewGuid();
    
    public string? Name { get; set; }
    
    public string? Description { get; set; }
}
