using FoodMerge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodMerge.Application.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<User> Users { get; set; }
    
    public DbSet<Ingredient> Ingredients { get; set; }
    
    public DbSet<Recipe> Recipes { get; set; }
    
    public DbSet<RecipeCategory> RecipeCategories { get; set; }
    
    public DbSet<IngredientCategory> IngredientCategories { get; set; }
}