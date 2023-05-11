# Take a base image from the public Docker Hub repositories
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
# Navigate to the “/source folder (create if not exists)
WORKDIR /source

# Copy csproj and download the dependencies listed in that file
COPY *.csproj ./
RUN dotnet restore

# Copy all files in the project folder
COPY . ./
RUN dotnet publish -c Release -o /app

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "dotnet-app.dll"]
