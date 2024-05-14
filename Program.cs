using Microsoft.AspNetCore.Http.Json;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.Configure<JsonOptions>(options => 
options.SerializerOptions.PropertyNamingPolicy = null);

var app = builder.Build();
app.UseCors(cors => cors.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.MapGet("/equipo/integrantes", PresentacionRequestHandler.ListarAlumnos);

app.MapGet("/banner/principal", PubliciadRequestHandler.ListarPublicidad);

app.MapGet("/principal/ofertas",OfertasRequesHandler.ObtenerOfertas);

app.Run();
