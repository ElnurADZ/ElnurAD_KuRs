FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base

EXPOSE 80
ENV ASPNETCORE_URLS="http://+:80"
ENV ASPNETCORE_ENVIRONMENT="Development"

WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /WEB_API

COPY ["WEB_API/WEB_API.csproj", "WEB_API/"]
COPY ["BusinessLogic/BusinessLogic.csproj", "BusinessLogic/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["DataAccess/DataAccess.csproj", "DataAccess/"]
RUN dotnet restore "WEB_API/WEB_API.csproj"

COPY . .
FROM build AS publish
RUN dotnet publish "WEB_API/WEB_API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WEB_API.dll"]