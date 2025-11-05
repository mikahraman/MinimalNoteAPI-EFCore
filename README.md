# Minimal Note API (EF Core)

This project is a demonstration of building high-performance, modern web APIs using **.NET 8 Minimal APIs** and **Entity Framework Core**. It implements a full CRUD (Create, Read, Update, Delete) service for managing personal notes, utilizing a Code-First approach for database management.

## Key Features
* **Minimal API Architecture:** Utilizes the latest .NET features for concise, low-overhead API endpoints without traditional Controllers.
* **Entity Framework Core:** Demonstrates modern ORM usage with Code-First migrations to manage MS SQL Server.
* **Full CRUD Operations:** Complete set of endpoints to manage data lifecycles.
* **Dependency Injection:** Proper registration of database contexts and services.

## Technology Stack
* **Framework:** .NET 8.0 (Minimal APIs)
* **Language:** C# 12
* **Database:** Microsoft SQL Server (LocalDB/Express)
* **ORM:** Entity Framework Core 8
* **Documentation:** Swagger UI

## How to Run
1. Clone the repository.
2. Open in Visual Studio 2022.
3. Update the connection string in `appsettings.json` if necessary.
4. Open Package Manager Console and run: `Update-Database` (to create the DB).
5. Run the application (F5) and explore via Swagger.

---
*Built as a portfolio project showcasing modern .NET backend capabilities.*
