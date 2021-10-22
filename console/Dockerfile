FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /source

COPY . .

RUN dotnet restore

RUN dotnet publish -c release -o /app --no-restore

ENTRYPOINT ["dotnet", "/app/example-app.dll"]