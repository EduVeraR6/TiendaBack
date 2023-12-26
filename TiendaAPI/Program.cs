using TiendaAPI.Entities;
using TiendaAPI.Repositories.ProductoRepository;
using TiendaAPI.Services.ProductoServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSqlServer<TiendaContext>(builder.Configuration.GetConnectionString("conexion"));


//Inyeccion de dependencias
builder.Services.AddScoped<IProducto , ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();





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
