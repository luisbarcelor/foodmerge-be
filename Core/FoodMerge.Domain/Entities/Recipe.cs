namespace FoodMerge.Domain.Entities;

public class Recipe
{
    public Guid Id { get; set; }
    
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public long Favorited { get; set; }
    
    public string Difficulty { get; set; }
    
    public string Source { get; set; }
}