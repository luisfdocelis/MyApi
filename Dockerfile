FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .
# CMD dotnet dev-certs https
# CMD dotnet dev-certs https --trust
# EXPOSE 8080 8443
ENTRYPOINT ["dotnet", "MyApi.dll", "--urls", "http://*:8080"]