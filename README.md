# Task Management API

This is a CRUD-based API for task management built with .NET 8 Web API following Clean Architecture principles.

## 🏗️ Architecture

The project follows Clean Architecture with four distinct layers:

- **API Layer** - HTTP endpoints and Swagger documentation
- **Application Layer** - Business logic and application services
- **Domain Layer** - Core entities and business rules
- **Infrastructure Layer** - Data access and external services

## 🚀 Quick Start

### Prerequisites
- .NET 8.0 SDK

### Build the solution
```bash
dotnet build
```

### Apply Database Migrations
```bash
cd src/TaskManagementApi.API
dotnet ef database update --project ../TaskManagementApi.Infrastructure
```

### Run the API
```bash
cd src/TaskManagementApi.API
dotnet run
```

### Access Swagger UI
Navigate to `https://localhost:5001/swagger` to explore the API documentation.

## 📋 Features

- ✅ Clean Architecture folder structure
- ✅ Swagger/OpenAPI documentation
- ✅ Entity Framework Core with SQL Server
- ✅ Database migrations
- ✅ SQL Server connection string configuration
- ✅ Health check endpoint
- ✅ .NET 8 Web API

## 📚 Documentation

See [PROJECT_SUMMARY.md](./PROJECT_SUMMARY.md) for detailed architecture documentation and implementation guide.

## 🔧 Configuration

Update SQL Server connection string in `src/TaskManagementApi.API/appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=TaskManagementDb;..."
}
```
