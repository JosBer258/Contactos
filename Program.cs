using Microsoft.EntityFrameworkCore;
using ApiSQL_Azure.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

//LA CONFIGURACION DE SERVICIOS PERMITE QUE, CUANDO TODO EMPEZIA A TRABAJAR LOS SERVICIOS YA ESTEN LISTOS
//ES UN METODO MUY IMPORTANTE
//AHORA LA MADRE SE HACE A TRAVES DE PROGRAM PRINCIPALMENTE


var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContactsContext>(opt => opt.UseSqlServer(connectionString));
//sent lamdas establecen la secuendia de un mteodo sin tener que declararlo explicamente, esta variable lo que hace es ejecutar
//un metodo de manera inmediata

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


//ENTITY FRANEWORK CORE es el gestor de comunicacion entre los elementos que se estan utilizando
//la comunicacion se hace con EF con comandos
/*
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

#se añadiran las dependencias al csproj y al proytecto

dotnet tool install --global dotnet-ef
dotnet-ef migrations add InitialCreate


*/