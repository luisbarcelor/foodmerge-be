using FoodMerge.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Check the database connection
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    bool isConnected = await dbContext.IsDatabaseConnectedAsync();
    
    if (isConnected)
    {
        Console.WriteLine("Connected to the database successfully!");
    }
    else
    {
        Console.WriteLine("Failed to connect to the database.");
    }
}


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

await app.RunAsync();

