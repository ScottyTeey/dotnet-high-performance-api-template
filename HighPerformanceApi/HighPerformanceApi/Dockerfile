# -----------------------------
# Dockerfile for HighPerformanceApi
# -----------------------------

# Base image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
# Note: USER $APP_UID will be set later, after we set up permissions

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HighPerformanceApi/HighPerformanceApi.csproj", "HighPerformanceApi/"]
RUN dotnet restore "./HighPerformanceApi/HighPerformanceApi.csproj"
COPY . .
WORKDIR "/src/HighPerformanceApi"
RUN dotnet build "./HighPerformanceApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./HighPerformanceApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage
FROM base AS final
WORKDIR /app

# Copy published app
COPY --from=publish /app/publish .

# Copy wait-for-it.sh script
COPY wait-for-it.sh /wait-for-it.sh
RUN chmod +x /wait-for-it.sh

# Switch to non-root user
USER $APP_UID

# Use wait-for-it to delay app start until SQL Server is ready
ENTRYPOINT ["/wait-for-it.sh", "sqlserver:1433", "--timeout=60", "--", "dotnet", "HighPerformanceApi.dll"]
