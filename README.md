# 🎮 GameStore API

A simple **ASP.NET Core Minimal API** for managing a video game store. This project demonstrates clean API design, CRUD operations, DTO usage, and Entity Framework Core with a relational database.

It’s built as a learning-focused backend project, showcasing how to structure a modern .NET Web API using **Minimal APIs**, **EF Core**, and **RESTful principles**.

---

## 🚀 Features

* Full **CRUD operations** for games
* RESTful endpoints (`GET`, `POST`, `PUT`, `DELETE`)
* DTO pattern for request/response separation
* Entity Framework Core for data access
* Database migrations support
* HTTP request testing via `.http` file (VS Code REST Client)

---

## 🧱 Tech Stack

* **.NET / ASP.NET Core** (Minimal API)
* **C#**
* **Entity Framework Core**
* **PostgreSQL / SQL Server** (configurable)
* **VS Code REST Client** (`.http` requests)

---

## 📁 Project Structure

```
GameStore.Api/
│
├── Data/
│   └── GameStoreContext.cs
│
├── Dtos/
│   ├── CreateGameDto.cs
│   ├── UpdateGameDto.cs
│   └── GameDto.cs
│
├── Endpoints/
│   └── GamesEndpoints.cs
│
├── Entities/
│   ├── Game.cs
│   └── Genre.cs
│
├── appsettings.json
├── Program.cs
├── games.http
└── GameStore.Api.csproj
```

---

## 🔗 API Endpoints

### Get all games

```
GET /games
```

### Get a game by ID

```
GET /games/{id}
```

### Create a new game

```
POST /games
Content-Type: application/json
```

```json
{
  "name": "Minecraft",
  "genre": "Kids and Family",
  "price": 19.99,
  "releaseDate": "2011-11-18"
}
```

### Update a game

```
PUT /games/{id}
Content-Type: application/json
```

```json
{
  "name": "Street Fighter II Turbo",
  "genre": "Fighting",
  "price": 9.99,
  "releaseDate": "1992-02-01"
}
```

### Delete a game

```
DELETE /games/{id}
```

---

## 🧪 Testing the API

You can test the API using the included **`games.http`** file in VS Code:

* Install the **REST Client** extension
* Open `games.http`
* Click **Send Request** above any endpoint

---

## 🛠️ Running the Project

1. Clone the repository
2. Update the database connection string in `appsettings.json`
3. Run migrations:

```
dotnet ef database update
```

4. Start the API:

```
dotnet run
```

The API will be available at:

```
http://localhost:5140
```

---

## 🎯 Purpose

This project was built to:

* Practice **Minimal APIs** in ASP.NET Core
* Demonstrate clean backend architecture
* Showcase CRUD functionality for a portfolio/GitHub

---

## 📌 Future Improvements

* Authentication & authorization
* Pagination and filtering
* Validation with FluentValidation
* Swagger / OpenAPI documentation

---

## 👤 Author

**Peter Saint John**
Backend Developer | ASP.NET Core | EF Core

---

⭐ If you found this useful, feel free to star the repo!
