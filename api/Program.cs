using Microsoft.AspNetCore.Mvc;
using timetrackerAPI.data;
using timetrackerAPI.data.sqlite;
using timetrackerAPI.models;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins(
                "http://localhost:8080" // Fin de la méthode
            )
            .AllowAnyHeader()         // Ajout de cette ligne pour autoriser les en-têtes
            .AllowAnyMethod();        // Et celle-ci pour autoriser tous les types de requêtes (GET, POST, etc.)
        }
    );
});

// Add services to the container
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins); // Utilisation de la politique CORS configurée
app.UseAuthorization();

app.MapControllers();

app.Run();
