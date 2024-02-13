# Stage 1: Bygga applikationen
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Kopiera projektfiler och restaurera beroenden
COPY . .
RUN dotnet restore
RUN dotnet build -c Release --no-restore

# Stage 2: Publicera applikationen
FROM build AS publish
RUN dotnet publish -c Release -o out --no-restore

# Stage 3: Kör applikationen
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=publish /app/out .
ENTRYPOINT ["dotnet", "PersonummerKontroll.dll"]
