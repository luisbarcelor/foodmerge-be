using System.ComponentModel.DataAnnotations;

namespace FoodMerge.Domain.Entities;

public class User
{
    [Key]
    public Guid Id { get; private set; } = Guid.NewGuid();
    
    public string? Name { get; set; }
    
    public string? LastName { get; set; }
    
    public string? Email { get; set; }
    
    public string? PictureUrl { get; set; }
    
}
