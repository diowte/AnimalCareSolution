# Animal Care Clinic

A veterinary clinic management web application built with **ASP.NET Core MVC**, **Entity Framework Core**, and **ASP.NET Identity**.  
The system helps a clinic manage **appointments**, **animals**, **owners**, and **medical/visit records** in a clean and organized way.

## Features
- Authentication (Login / Register) with ASP.NET Identity
- Role-based access (Admin / Staff) *(if enabled in the project)*
- CRUD management:
  - Animals (pets)
  - Owners (clients)
  - Veterinarians
  - Appointments (create, edit, cancel)
- Appointment scheduling & status tracking
- Organized clinic data using EF Core (SQL Server)

## Tech Stack
- C#
- ASP.NET Core MVC
- Entity Framework Core
- ASP.NET Identity
- SQL Server
- Razor Views + Bootstrap

## Getting Started (Local Setup)

### Prerequisites
- Visual Studio 2022
- .NET SDK (matching the project)
- SQL Server / SQL Server Express

### 1) Configure the database connection
Open `appsettings.json` and set your connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=AnimalCareDb;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
