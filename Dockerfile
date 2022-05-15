# Dockerfile
FROM mcr.microsoft.com/dotnet/framework/sdk

WORKDIR /app

COPY /WindowsFormsApp1/Atlas.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet  publish Atlas_project.sln -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "aspnetcoreapp.dll"]