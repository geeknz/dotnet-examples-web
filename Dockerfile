FROM microsoft/dotnet:1.1.0-sdk-projectjson

ADD . /app

WORKDIR /app

RUN dotnet restore

WORKDIR /app/src/WebApp/

RUN dotnet build

CMD ASPNETCORE_URLS=http://*:$PORT dotnet run -p project.json
