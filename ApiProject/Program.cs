
using ApiProject.NameServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Lifetimes:
// Scoped -> creates a new instance for each HTTP Request
// Transient --> Creates a new instance every time the service is requested
// Singleton --> Creates only one instance for as long as the application is running
builder.Services.AddScoped<NameService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();