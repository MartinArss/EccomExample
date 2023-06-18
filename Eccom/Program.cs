global using Domain.Entities;
global using Microsoft.EntityFrameworkCore;
global using Eccom.DtContext;
global using Domain.Dto;
global using Domain.Dto.Categoria;
global using AutoMapper;
global using Eccom.Services.CategoriaService;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CONEXION A BASE DE DATOS
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conn"));
});

// MAPEO DE LOS MODELOS
builder.Services.AddAutoMapper(typeof(Program).Assembly);
// INYECCION DE DEPENDENCIAS AL SISTEMA
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

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

// Clase para mapear los modelos de la base de datos
public class PerfilesAutoMapper : Profile
{
    public PerfilesAutoMapper()
    {
        CreateMap<Categoria, ObtenerCategoriaDto>();
        CreateMap<CrearCategoriaDto, Categoria>();
        CreateMap<ActualizarCategoriaDto, Categoria>();
    }
}