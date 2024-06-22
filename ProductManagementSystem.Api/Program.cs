using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Application.Interfaces;
using ProductManagementSystem.Application.Mapping;
using ProductManagementSystem.Application.Services;
using ProductManagementSystem.Domain.Entities;
using ProductManagementSystem.Domain.Interfaces;
using ProductManagementSystem.Infrastructure;
using ProductManagementSystem.Infrastructure.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = builder.Configuration;



// Register repositories and other services
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IGenericRepository<Product>, GenericRepository<Product>>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));


builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
});

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
