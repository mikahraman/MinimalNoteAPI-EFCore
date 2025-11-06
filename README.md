# Minimal Note API (EF Core)

This project is a demonstration of building high-performance, modern web APIs using **.NET 8 Minimal APIs** and **Entity Framework Core**. It implements a full CRUD (Create, Read, Update, Delete) service for managing personal notes, utilizing a Code-First approach for database management.

## Key Features
* **Minimal API Architecture:** Utilizes the latest .NET features for concise, low-overhead API endpoints without traditional Controllers.
* **Entity Framework Core:** Demonstrates modern ORM usage with Code-First migrations to manage MS SQL Server.
* **Full CRUD Operations:** Complete set of endpoints to manage data lifecycles.
* **Dependency Injection:** Proper registration of database contexts and services.
<img width="1681" height="840" alt="Screenshot1" src="https://github.com/user-attachments/assets/b4cc83b8-057e-494e-80e7-3802d704d9cc" />
<img width="1669" height="770" alt="Screenshot2" src="https://github.com/user-attachments/assets/411e4f80-01c7-42fa-a2ac-7898baddab40" />
<img width="1616" height="785" alt="Screenshot3" src="https://github.com/user-attachments/assets/067dbf8b-c289-44c3-a373-ecad643f4848" />
<img width="1629" height="822" alt="Screenshot4" src="https://github.com/user-attachments/assets/cb4be869-2218-42d3-ab0e-4b8dcf2ad012" />
<img width="1610" height="803" alt="Screenshot5" src="https://github.com/user-attachments/assets/95f671ad-ffc9-4880-b303-08dfadeeba41" />
<img width="1629" height="662" alt="Screenshot6" src="https://github.com/user-attachments/assets/aa7c093b-f96a-488b-848a-60d9c55aafce" />
<img width="1670" height="486" alt="Screenshot7" src="https://github.com/user-attachments/assets/d4ab024c-136a-45e9-b9e1-4314619a4b0a" />
<img width="1640" height="848" alt="Screenshot8" src="https://github.com/user-attachments/assets/86101bdd-32b5-4853-90c7-a3f79ddc323e" />
<img width="1620" height="503" alt="Screenshot9" src="https://github.com/user-attachments/assets/2c201811-6e7f-41e8-933a-acdc0ca8c64e" />

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
