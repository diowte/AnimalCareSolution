# 🐾 Animal Care Clinic

Animal Care Clinic is a veterinary clinic management web application built with ASP.NET Core MVC, Entity Framework Core, and ASP.NET Identity.

The system allows clinic staff to manage animals, owners, veterinarians, appointments, and medical records in an organized and secure way.

---

## 🚀 Features

- User authentication (Login / Register)
- Role-based authorization (Admin / Staff)
- Full CRUD operations for:
  - Animals (pets)
  - Owners (clients)
  - Veterinarians
  - Appointments
- Appointment scheduling and tracking
- Secure password configuration
- SQL Server database integration using Entity Framework Core

---

## 🛠 Technologies Used

- C#
- ASP.NET Core MVC
- Entity Framework Core
- ASP.NET Identity
- SQL Server
- Razor Views
- Bootstrap

---

## ⚙️ Installation & Setup (Local)

### 1) Configure the Database

Open `appsettings.json` and update the connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=AnimalCareDb;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

---

### 2) Create / Update the Database

Using **Package Manager Console** in Visual Studio:

```powershell
Update-Database
```

Or using the .NET CLI:

```bash
dotnet ef database update
```

This will automatically create the database and apply migrations.

---

### 3) Run the Application

Run from Visual Studio (F5)  
or use the CLI:

```bash
dotnet run


---

## 📁 Project Architecture

- Models → Application entities
- Data → DbContext and migrations
- Controllers → MVC controllers
- Views → Razor UI pages
- wwwroot → Static assets
- appsettings.json → Configuration settings

---

## 👨‍💻 Author

Akram Boughlala  


