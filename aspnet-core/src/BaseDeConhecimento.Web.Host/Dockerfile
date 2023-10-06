FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/BaseDeConhecimento.Web.Host/BaseDeConhecimento.Web.Host.csproj", "src/BaseDeConhecimento.Web.Host/"]
COPY ["src/BaseDeConhecimento.Web.Core/BaseDeConhecimento.Web.Core.csproj", "src/BaseDeConhecimento.Web.Core/"]
COPY ["src/BaseDeConhecimento.Application/BaseDeConhecimento.Application.csproj", "src/BaseDeConhecimento.Application/"]
COPY ["src/BaseDeConhecimento.Core/BaseDeConhecimento.Core.csproj", "src/BaseDeConhecimento.Core/"]
COPY ["src/BaseDeConhecimento.EntityFrameworkCore/BaseDeConhecimento.EntityFrameworkCore.csproj", "src/BaseDeConhecimento.EntityFrameworkCore/"]
WORKDIR "/src/src/BaseDeConhecimento.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/BaseDeConhecimento.Web.Host", "src/BaseDeConhecimento.Web.Host"]
COPY ["src/BaseDeConhecimento.Web.Core", "src/BaseDeConhecimento.Web.Core"]
COPY ["src/BaseDeConhecimento.Application", "src/BaseDeConhecimento.Application"]
COPY ["src/BaseDeConhecimento.Core", "src/BaseDeConhecimento.Core"]
COPY ["src/BaseDeConhecimento.EntityFrameworkCore", "src/BaseDeConhecimento.EntityFrameworkCore"]
WORKDIR "/src/src/BaseDeConhecimento.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "BaseDeConhecimento.Web.Host.dll"]
