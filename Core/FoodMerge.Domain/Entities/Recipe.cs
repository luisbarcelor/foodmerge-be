using System.ComponentModel.DataAnnotations;
using FoodMerge.Domain.Enums;

namespace FoodMerge.Domain.Entities;

public class Recipe
{
    [Key]
    public Guid Id { get; private set; } = Guid.NewGuid();
    
    [MaxLength(100)]
    public string? Title { get; set; }
    
    [MaxLength(500)]
    public string? Description { get; set; }

    public long Favorited { get; set; }

    public Difficulty? Difficulty { get; set; }

    public Uri? Source { get; set; }
}
