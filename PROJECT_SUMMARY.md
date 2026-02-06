# .NET 6 Web API - Task Management API

## Project Overview
This is a Task Management API built with .NET 6 following Clean Architecture principles. The project structure provides clear separation of concerns across four distinct layers.

## Clean Architecture Layers

### 1. **Domain Layer** (TaskManagementApi.Domain)
- **Purpose**: Core business entities and domain logic
- **Dependencies**: None (innermost layer)
- **Location**: `src/TaskManagementApi.Domain/`
- **Contents**: 
  - `Entities/TaskItem.cs` - Sample domain entity

### 2. **Application Layer** (TaskManagementApi.Application)
- **Purpose**: Application business logic and interfaces
- **Dependencies**: Domain layer only
- **Location**: `src/TaskManagementApi.Application/`
- **Contents**:
  - `Interfaces/IApplicationService.cs` - Application service interfaces

### 3. **Infrastructure Layer** (TaskManagementApi.Infrastructure)
- **Purpose**: External concerns (database, file system, external services)
- **Dependencies**: Application layer (and Domain transitively)
- **Location**: `src/TaskManagementApi.Infrastructure/`
- **Contents**:
  - `Data/ApplicationDbContext.cs` - Data access implementation placeholder

### 4. **API Layer** (TaskManagementApi.API)
- **Purpose**: HTTP API endpoints and presentation logic
- **Dependencies**: Application and Infrastructure layers
- **Location**: `src/TaskManagementApi.API/`
- **Contents**:
  - `Program.cs` - Application startup with Swagger configuration
  - `appsettings.json` - Configuration including SQL Server connection string
  - `Controllers/HealthController.cs` - Sample API endpoint

## Key Features

### ✅ Swagger/OpenAPI Integration
The API is configured with Swagger for interactive API documentation:
- Swagger UI available at `/swagger` endpoint in development
- Complete API documentation with OpenAPI specification
- Configured in `Program.cs` with SwaggerGen and SwaggerUI

### ✅ SQL Server Configuration
Connection string placeholder in `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=TaskManagementDb;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
}
```

### ✅ Health Check Endpoint
- Endpoint: `GET /api/health`
- Returns: `{ "status": "Healthy", "timestamp": "..." }`

## Project Structure
```
ayush-task-api-management/
├── TaskManagementApi.slnx          # Solution file
├── .gitignore                       # Git ignore for .NET projects
├── README.md                        # Project overview
└── src/
    ├── README.md                    # Architecture documentation
    ├── TaskManagementApi.API/
    │   ├── Controllers/
    │   │   └── HealthController.cs
    │   ├── Program.cs
    │   ├── appsettings.json
    │   ├── appsettings.Development.json
    │   └── TaskManagementApi.API.csproj
    ├── TaskManagementApi.Application/
    │   ├── Interfaces/
    │   │   └── IApplicationService.cs
    │   └── TaskManagementApi.Application.csproj
    ├── TaskManagementApi.Domain/
    │   ├── Entities/
    │   │   └── TaskItem.cs
    │   └── TaskManagementApi.Domain.csproj
    └── TaskManagementApi.Infrastructure/
        ├── Data/
        │   └── ApplicationDbContext.cs
        └── TaskManagementApi.Infrastructure.csproj
```

## Getting Started

### Prerequisites
- .NET 6.0 SDK (or .NET 8+ SDK for building with cross-version support)

### Build
```bash
dotnet build
```

### Run
```bash
cd src/TaskManagementApi.API
dotnet run
```

### Access Swagger UI
Navigate to `https://localhost:5001/swagger` (or the URL shown in console)

## Configuration

### SQL Server Connection
Update the connection string in `src/TaskManagementApi.API/appsettings.json`:
- Replace `YOUR_SERVER_NAME` with your SQL Server instance
- Replace `YOUR_USERNAME` with your database username
- Replace `YOUR_PASSWORD` with your database password

## Build Status
✅ Project structure created successfully
✅ All projects build without errors
✅ Clean Architecture dependencies correctly configured
✅ Swagger integration complete
✅ Configuration files in place

## Next Steps
1. Implement Entity Framework Core DbContext in Infrastructure layer
2. Add CRUD operations for TaskItem entity
3. Implement repository pattern in Infrastructure layer
4. Add application services in Application layer
5. Create full REST API endpoints in API layer
6. Add validation and error handling
7. Implement authentication and authorization
8. Add unit and integration tests
