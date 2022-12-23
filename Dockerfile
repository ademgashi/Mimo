FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY src/Mimo.Domain/Mimo.Domain.csproj ./src/Mimo.Domain/
COPY src/Mimo.Application/Mimo.Application.csproj ./src/Mimo.Application/
COPY src/Mimo.Infrastructure/Mimo.Infrastructure.csproj ./src/Mimo.Infrastructure/
COPY src/Mimo.Api/Mimo.Api.csproj ./src/Mimo.Api/
RUN dotnet restore ./src/Mimo.Api/Mimo.Api.csproj

COPY . ./
RUN dotnet publish ./src/Mimo.Api -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
EXPOSE 5432
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "Mimo.Api.dll"]
