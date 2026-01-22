using System.Security.Cryptography.X509Certificates;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.MapGamesEndpoints();


app.Run();
