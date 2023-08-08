FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app
COPY . /app
COPY input /app

CMD ["dotnet", "run"]
