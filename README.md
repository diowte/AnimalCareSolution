# 🐾 Animal Care Clinic

Veterinary clinic management web application built with ASP.NET Core MVC, Entity Framework Core, and ASP.NET Identity.

## Features
- Authentication (Login / Register)
- Role-based access (Admin / Staff)
- CRUD: Animals, Owners, Veterinarians, Appointments
- Appointment scheduling
- SQL Server integration (EF Core)

## Tech Stack
C#, ASP.NET Core MVC, EF Core, ASP.NET Identity, SQL Server, Razor Views, Bootstrap

## Local Setup

1) Configure database – update `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=AnimalCareDb;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

2) Apply migrations:

```powershell
Update-Database
```

or

```bash
dotnet ef database update
```

3) Run the application:

```bash
dotnet run
```

Open the URL shown in the console (ex: https://localhost:7056)

## Author
Akram Boughlala  
GitHub: https://github.com/diowte
