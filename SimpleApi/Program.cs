using Microsoft.EntityFrameworkCore;
using SimpleApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure SQLite database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure JSON serialization to match the required format
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "SimpleApi V1");
    });
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

// Create database if it doesn't exist
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    context.Database.EnsureCreated();
}

// Get the URLs the application is listening on
var urls = app.Urls;
if (urls == null || !urls.Any())
{
    // Default URLs from launchSettings.json
    urls = new[] { "https://localhost:7123", "http://localhost:5123" };
}

Console.WriteLine();
Console.WriteLine("Application started!");
Console.WriteLine($"Swagger UI: {urls.First()}/swagger");
Console.WriteLine($"API Endpoint: {urls.First()}/api/transactions");
Console.WriteLine();

app.Run();