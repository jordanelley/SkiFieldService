FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

COPY ./ ./
RUN dotnet restore
RUN dotnet build -c Release
RUN dotnet publish -c Release -o release

# # Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/release .
CMD ["echo","Hellow W"]
ENV ASPNETCORE_URLS=http://+:5000
ENTRYPOINT ["dotnet","Ski_App_Service.dll"] 