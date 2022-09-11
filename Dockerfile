FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
RUN apt-get update && apt-get install -y \
    cmake \
    g++ \
    && rm -rf /var/lib/apt/lists/*
WORKDIR /app
COPY /Dotnet ./
RUN dotnet restore ./ConsoleClient/ConsoleClient.csproj
RUN dotnet publish ./ConsoleClient/ConsoleClient.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
RUN apt-get update && apt-get install -y \
    cmake \
    g++ \
    && rm -rf /var/lib/apt/lists/*
COPY /Native/NativeLibrary /NativeLibrary
WORKDIR /NativeLibrary/build
RUN cmake ..
RUN make
RUN make install
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "ConsoleClient.dll"]