using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.DataAccess;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Datos.Repository;
using ProyectoPersonal.Negocio.Interfaces;
using ProyectoPersonal.Negocio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<ProyectoPersonalDataBase>();

// Registro de Repositories
builder.Services.AddScoped<ITblAreaRepository, TblAreaRepository>();
builder.Services.AddScoped<ITblEdificioRepository, TblEdificioRepository>();
builder.Services.AddScoped<ITblEspacioRepository, TblEspacioRepository>();
builder.Services.AddScoped<ITblCategoriasRepository, TblCategoriasRepository>();
builder.Services.AddScoped<ITblMarcaRepository, TblMarcaRepository>();
builder.Services.AddScoped<ITblProductoRepository, TblProductoRepository>();
builder.Services.AddScoped<ITblActivoRepository, TblActivoRepository>();
builder.Services.AddScoped<ITblResponsableRepository, TblResponsableRepository>();
builder.Services.AddScoped<ITblAdquisicionRepository, TblAdquisicionRepository>();
builder.Services.AddScoped<ITblDetalle_adquisicionRepository, TblDetalle_adquisicionRepository>();
builder.Services.AddScoped<ITblPersonaRepository, TblPersonaRepository>();
builder.Services.AddScoped<ITblEstudianteRepository, TblEstudianteRepository>();
builder.Services.AddScoped<ITblDocenteRepository, TblDocenteRepository>();
builder.Services.AddScoped<ITblAdministrativoRepository, TblAdministrativoRepository>();
builder.Services.AddScoped<ITblRolRepository, TblRolRepository>();
builder.Services.AddScoped<ITblUsuarioRepository, TblUsuarioRepository>();
builder.Services.AddScoped<ITblProgramRepository, TblProgramRepository>();
builder.Services.AddScoped<ITblPermisosRepository, TblPermisosRepository>();
builder.Services.AddScoped<ITblPrestamoRepository, TblPrestamoRepository>();
builder.Services.AddScoped<ITblPrestamo_activoRepository, TblPrestamo_activoRepository>();
builder.Services.AddScoped<ITblTransferencia_activoRepository, TblTransferencia_activoRepository>();

// Registro de Services
builder.Services.AddScoped<ITblAreaService, TblAreaService>();
builder.Services.AddScoped<ITblEdificioService, TblEdificioService>();
builder.Services.AddScoped<ITblEspacioService, TblEspacioService>();
builder.Services.AddScoped<ITblCategoriasService, TblCategoriasService>();
builder.Services.AddScoped<ITblMarcaService, TblMarcaService>();
builder.Services.AddScoped<ITblProductoService, TblProductoService>();
builder.Services.AddScoped<ITblActivoService, TblActivoService>();
builder.Services.AddScoped<ITblResponsableService, TblResponsableService>();
builder.Services.AddScoped<ITblAdquisicionService, TblAdquisicionService>();
builder.Services.AddScoped<ITblDetalle_adquisicionService, TblDetalle_adquisicionService>();
builder.Services.AddScoped<ITblPersonaService, TblPersonaService>();
builder.Services.AddScoped<ITblEstudianteService, TblEstudianteService>();
builder.Services.AddScoped<ITblDocenteService, TblDocenteService>();
builder.Services.AddScoped<ITblAdministrativoService, TblAdministrativoService>();
builder.Services.AddScoped<ITblRolService, TblRolService>();
builder.Services.AddScoped<ITblUsuarioService, TblUsuarioService>();
builder.Services.AddScoped<ITblProgramService, TblProgramService>();
builder.Services.AddScoped<ITblPermisosService, TblPermisosService>();
builder.Services.AddScoped<ITblPrestamoService, TblPrestamoService>();
builder.Services.AddScoped<ITblPrestamo_activoService, TblPrestamo_activoService>();
builder.Services.AddScoped<ITblTransferencia_activoService, TblTransferencia_activoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();