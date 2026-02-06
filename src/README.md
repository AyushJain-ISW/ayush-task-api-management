# Task Management API - Clean Architecture

This project follows Clean Architecture principles with clear separation of concerns across four layers:

## Project Structure

```
src/
├── TaskManagementApi.API/          # Presentation Layer
│   ├── Controllers/                # API Controllers
│   ├── Program.cs                  # Application entry point with Swagger
│   └── appsettings.json           # Configuration including SQL Server connection
│
├── TaskManagementApi.Application/  # Application Layer
│   └── Interfaces/                 # Application service interfaces
│
├── TaskManagementApi.Domain/       # Domain Layer (Core)
│   └── Entities/                   # Domain entities
│
└── TaskManagementApi.Infrastructure/ # Infrastructure Layer
    └── Data/                       # Data access implementation
```

## Layer Dependencies

- **Domain**: No dependencies (innermost layer)
- **Application**: Depends on Domain
- **Infrastructure**: Depends on Application
- **API**: Depends on Application and Infrastructure

## Getting Started

### Prerequisites
- .NET 6.0 SDK or later

### Build the Solution
```bash
dotnet build
```

### Run the API
```bash
cd src/TaskManagementApi.API
dotnet run
```

The API will be available at `https://localhost:5001` (or the port shown in console).

### Access Swagger UI
Navigate to `https://localhost:5001/swagger` to view the API documentation.

## Configuration

Update the SQL Server connection string in `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=TaskManagementDb;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
}
```
