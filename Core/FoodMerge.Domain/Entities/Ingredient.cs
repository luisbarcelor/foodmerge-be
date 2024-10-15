namespace FoodMerge.Domain.Entities;

public class Ingredient
{
    private Guid Id { get; set; }
    
    private string Name { get; set; }
    
    private string Quantity { get; set; }
    
    private string Description { get; set; }
}