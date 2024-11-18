# Clean Architecture with Minimal APIs and MongoDB (.NET 9)
 Prjoect Developed with .NET 9, Minimal APIs, MongoDB for persistence, and CQRS with MediatR for separation of concerns. The project follows best practices for modern .NET application development.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Instructions for Configuration](#instructions-for-configuration)
- [Usage](#usage)
- [License](#license)

## Features

- **Clean Architecture**:
  - Clear separation of concerns into `Domain`, `Application`, `Infrastructure`, and `Presentation` layers.
- **Minimal APIs**:
  - Lightweight and fast routing for HTTP endpoints.
- **MongoDB Integration**:
  - Flexible NoSQL database with centralized `MongoDbContext`.
- **CQRS with MediatR**:
  - Command-query separation with pipeline behaviors.
- **Validation**:
  - Input validation using **FluentValidation**.
- **Error Handling**:
  - Middleware for consistent exception handling.
- **Interactive API Documentation**:
  - Auto-generated **Swagger** UI.

---

## Technologies Used

- **.NET 9**: Modern framework for web applications.
- **MongoDB**: NoSQL database for scalable data storage.
- **MediatR**: CQRS pattern with request/response handlers.
- **FluentValidation**: Robust input validation framework.
- **Swagger**: API documentation and testing tool.

## Project Structure

```plaintext
CleanArchitectureDotNet9
├── CleanArchitectureDotNet9.Domain
│   ├── Entities
│   │   └── User.cs
│   └── Common
│       └── BaseModel.cs
├── CleanArchitectureDotNet9.Application
│   ├── Common
│   │   ├── ValidationBehavior.cs
│   │   └── SystemExceptions.cs
│   ├── Features
│   │   └── UserFeatures
│   │       ├── Add
│   │           ├── AddUserHandler.cs
│   │           ├── AddUserMapper.cs
│   │           ├── AddUserRequest.cs
│   │           ├── AddUserResponse.cs
│   │           └── AddUserValidator.cs
│   ├── Behaviors
│   │   └── ValidationBehavior.cs
│   └── Repository
|       ├── ICommon
│       │   └── IBaseRepository.cs
|       └── UserRepository
│           └── IUserRepository.cs
├── CleanArchitectureDotNet9.Infrastructure
│   ├── Persistence
│   │   └── DotNetContext.cs
│   ├── Repositories
│   │   ├── BaseRepository.cs
│   │   └── UserRepository.cs
│   └── Settings
│       └── MongoSettings.cs
├── CleanArchitectureDotNet9.Presentation
│   ├── Endpoints
│   │   └── UserEndpoints.cs
│   ├── Extensions
│   │   ├── ErrorHandlerExtensions.cs
│   │   ├── CorsExtensions.cs
│   │   ├── SwaggerExtensions.cs
│   │   └── ApiBehaviorExtensions.cs
│   └── Program.cs
└── appsettings.json

## Installation
To get started with the DotNetFireStore project, follow these steps:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/MohanedZekry/CleanArchitectureDotNet9.git

# Instructions for Configuration

1. **Open your `appsettings.json` file** in your .NET Core project.

2. **Locate the Firestore configuration section**, which should look like this:

   ```json
   "MongoDB": {
     "ConnectionString": "your-firestore-project-id",
     "DatabaseName": "Path/your-service-key.json"
   },
   
Replace the placeholders with your actual connections project details:

## Usage
After setting up the project, you can start using it to interact with MongoDb.

## License
This project is licensed under the MIT License. See the LICENSE file for details.
