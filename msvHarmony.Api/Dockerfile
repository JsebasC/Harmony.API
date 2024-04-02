#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["msvHarmony.Api/msvHarmony.Api.csproj", "msvHarmony.Api/"]
COPY ["msvHarmony.Application/msvHarmony.Application.csproj", "msvHarmony.Application/"]
COPY ["msvHarmony.Domain/msvHarmony.Domain.csproj", "msvHarmony.Domain/"]
COPY ["msvHarmony.Infrastructure/msvHarmony.Infrastructure.csproj", "msvHarmony.Infrastructure/"]
RUN dotnet restore "msvHarmony.Api/msvHarmony.Api.csproj"
COPY . .
WORKDIR "/src/msvHarmony.Api"
RUN dotnet build "msvHarmony.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "msvHarmony.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "msvHarmony.Api.dll"]