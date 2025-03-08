# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy the project files and restore dependencies
COPY CleanArchitectureDotNet9.WebAPI/*.csproj ./CleanArchitectureDotNet9.WebAPI/
COPY CleanArchitectureDotNet9.Application/*.csproj ./CleanArchitectureDotNet9.Application/
COPY CleanArchitectureDotNet9.Domain/*.csproj ./CleanArchitectureDotNet9.Domain/
COPY CleanArchitectureDotNet9.Persistence/*.csproj ./CleanArchitectureDotNet9.Persistence/

WORKDIR /app
RUN dotnet restore CleanArchitectureDotNet9.WebAPI/CleanArchitectureDotNet9.WebAPI.csproj
RUN dotnet restore CleanArchitectureDotNet9.Application/CleanArchitectureDotNet9.Application.csproj
RUN dotnet restore CleanArchitectureDotNet9.Domain/CleanArchitectureDotNet9.Domain.csproj
RUN dotnet restore CleanArchitectureDotNet9.Persistence/CleanArchitectureDotNet9.Persistence.csproj


# Copy the remaining files and build the application
COPY . .
RUN dotnet publish CleanArchitectureDotNet9.WebAPI/CleanArchitectureDotNet9.WebAPI.csproj -c Release -o out

# Use the official ASP.NET Core runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Expose the port the application runs on
EXPOSE 8080

# Set the entry point for the container
ENTRYPOINT ["dotnet", "CleanArchitectureDotNet9.WebAPI.dll"]
