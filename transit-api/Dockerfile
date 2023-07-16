#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["transit-api/transit-api.csproj", "transit-api/"]
RUN dotnet restore "transit-api/transit-api.csproj"
COPY . .
WORKDIR "/src/transit-api"
RUN dotnet build "transit-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "transit-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "transit-api.dll"]