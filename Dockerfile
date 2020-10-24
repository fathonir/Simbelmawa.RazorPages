# https://hub.docker.com/_/microsoft-dotnet-core
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /source

# pwd : /source
# copy csproj and restore as distinct layers
COPY *.sln .
COPY Simbelmawa/. ./Simbelmawa/
COPY Simbelmawa.Data/. ./Simbelmawa.Data/
COPY Simbelmawa.Identity/. ./Simbelmawa.Identity/
COPY Simbelmawa.Models/. ./Simbelmawa.Models/
RUN dotnet restore -r linux-x64 -v normal

# build app
RUN dotnet publish ./Simbelmawa/Simbelmawa.csproj -c release -o /publish -r linux-x64 --self-contained false --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-bionic
WORKDIR /publish
COPY --from=build /publish ./
ENTRYPOINT ["./publish"]