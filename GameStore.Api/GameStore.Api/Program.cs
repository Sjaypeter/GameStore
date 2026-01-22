using System.Security.Cryptography.X509Certificates;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);


var connString = "Data Source=GameStore.db";
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapGamesEndpoints();


app.Run();
