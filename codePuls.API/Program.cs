using CodePulse.API.Data;
using CodePulse.API.Repositories.Implementation;
using CodePulse.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CodePulseConnectionString"));
});

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app;
try
{
    app = builder.Build();
}
catch (ReflectionTypeLoadException ex)
{
    Console.WriteLine("ReflectionTypeLoadException during Build():");
    foreach (var le in ex.LoaderExceptions)
    {
        Console.WriteLine(le?.Message);
        if (le is Exception ie && ie.StackTrace != null)
        {
            Console.WriteLine(ie.StackTrace);
        }
    }
    throw;
}

// Configure the HTTP request pipeline.
// Always enable Swagger UI and serve it at the app root so opening the app shows Swagger immediately.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CodePulse API V1");
    // Serve the Swagger UI at root ('/')
    c.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
});

app.UseAuthorization();

app.MapControllers();

try
{
    app.Run();
}
catch (ReflectionTypeLoadException ex)
{
    Console.WriteLine("ReflectionTypeLoadException during Run():");
    foreach (var le in ex.LoaderExceptions)
    {
        Console.WriteLine(le?.Message);
        if (le is Exception ie && ie.StackTrace != null)
        {
            Console.WriteLine(ie.StackTrace);
        }
    }
    throw;
}
