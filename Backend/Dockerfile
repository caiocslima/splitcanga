# Use the official .NET SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy project files to the working directory
COPY . .

# Restore dependencies and build the project
RUN dotnet restore
RUN dotnet build -c Release -o out

# Define the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy files from the build directory to the working directory
COPY --from=build /app/out ./

# Install the wait-for-it utility
RUN apt-get update && apt-get install -y wait-for-it

# Expose the port the application will listen on
EXPOSE 4003

# Command to wait for PostgreSQL initialization and start the application
CMD ["wait-for-it", "postgres:5432", "--", "dotnet", "Backend.dll"]
