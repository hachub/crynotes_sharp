FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CryNotes.Api.csproj", "CryNotes.Api/"]
RUN dotnet restore "CryNotes.Api/CryNotes.Api.csproj"
COPY . ./CryNotes.Api
WORKDIR "/src/CryNotes.Api"
RUN ls -ls
RUN dotnet build "CryNotes.Api.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "CryNotes.Api.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CryNotes.Api.dll"]
