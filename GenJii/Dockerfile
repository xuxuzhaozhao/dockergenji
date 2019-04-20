FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["GenJii/GenJii.csproj", "GenJii/"]
RUN dotnet restore "GenJii/GenJii.csproj"
COPY . .
WORKDIR "/src/GenJii"
RUN dotnet build "GenJii.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GenJii.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GenJii.dll"]