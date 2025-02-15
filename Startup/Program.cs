using FoodMerge.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables();

ConfigureServices(builder.Services);

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILogger<Program>>();

// Check the database connection
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    var isConnected = await dbContext.IsDatabaseConnectedAsync();

    if (isConnected)
    {
        logger.LogInformation("Database connection successful.");
    }
    else
    {
        logger.LogError("Database connection failed.");
    }
}

logger.LogInformation("Starting the application in {EnvironmentName} environment.", app.Environment.EnvironmentName);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

await app.RunAsync();
return;


void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
    });
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
}

