using Back_End.Contexts;
using Back_End.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//// Retrieve the configuration from appsettings.json
var configuration = new ConfigurationBuilder()
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddDbContext<TodoItemContext>(opt =>
    opt.UseInMemoryDatabase(configuration.GetConnectionString("DatabaseConnection"))
);
builder.Services.AddScoped<TodoItemService>();

builder.Services.AddDbContext<TodoListContext>(opt =>
    opt.UseInMemoryDatabase(configuration.GetConnectionString("DatabaseConnection"))
);
builder.Services.AddScoped<TodoListService>();

// register the required Swagger services for NSwag
builder.Services.AddSwaggerDocument();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Register the Swagger generator and the Swagger UI middlewares
    app.UseOpenApi();
    app.UseSwaggerUi3();    
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
