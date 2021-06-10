#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["LW.XtramileSolutionsTest/LW.XtramileSolutionsTest.csproj", "LW.XtramileSolutionsTest/"]
RUN dotnet restore "LW.XtramileSolutionsTest/LW.XtramileSolutionsTest.csproj"
COPY . .
WORKDIR "/src/LW.XtramileSolutionsTest"
RUN dotnet build "LW.XtramileSolutionsTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LW.XtramileSolutionsTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LW.XtramileSolutionsTest.dll"]