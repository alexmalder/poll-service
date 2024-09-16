FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy everything
COPY . .
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/bin .
#ENTRYPOINT ["dotnet", "/app/DotNetCrudWebApi.dll"]
CMD ["dotnet", "/app/Release/net8.0/DotNetCrudWebApi.dll"]
