using System.Security.Cryptography.X509Certificates;
using GameStore.Api.Endpoints;
using Microsoft.VisualBasic;

var builder = WebApplication.CreateBuilder(args);


var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

app.MapGamesEndpoints();

AppWinStyle.MigrateDb();


app.Run();
