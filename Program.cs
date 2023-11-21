using Microsoft.EntityFrameworkCore;
using MyApi.Filters;
using MyApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers(options =>
{
    options.Filters.Add<HttpResponseExceptionFilter>();
});

// DB context connection settings
IConfiguration config =  builder.Configuration; 
IConfigurationSection section = config.GetSection(key: "ConnectionStrings");
string? connection = section.GetConnectionString(name: "WebApiDatabase");
builder.Services.AddDbContext<MyDatabaseContext>( options => options.UseNpgsql( connection ));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error-development");
    app.UseSwagger();
    app.UseSwaggerUI();

} else {
    app.UseExceptionHandler("/error");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
