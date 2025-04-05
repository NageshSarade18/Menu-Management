# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy the project and restore dependencies
COPY Menu.csproj ./
RUN dotnet restore Menu.csproj

# Copy the entire project and build the release version
COPY . ./
RUN dotnet publish Menu.csproj -c Release -o /app/publish

# Use the .NET runtime image for the final container
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

# Copy the built application from the previous stage
COPY --from=build /app/publish .

# Set the environment variable
ENV ASPNETCORE_ENVIRONMENT=Development

# Expose the default port
EXPOSE 5149
#EXPOSE 7106

# Run the application
ENTRYPOINT ["dotnet", "Menu.dll"]

