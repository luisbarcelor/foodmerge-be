using FoodMerge.Application.Interfaces;
using FoodMerge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodMerge.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options), IApplicationDbContext
{
    public DbSet<User> Users { get; set; }
    
    public DbSet<Ingredient> Ingredients { get; set; }
    
    public DbSet<Recipe> Recipes { get; set; }
    
    public DbSet<RecipeCategory> RecipeCategories { get; set; }
    
    public DbSet<IngredientCategory> IngredientCategories { get; set; }
    
    public async Task<bool> IsDatabaseConnectedAsync()
    {
        try
        {
            return await Database.CanConnectAsync();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.StackTrace);
            return false;
        }
    }
}