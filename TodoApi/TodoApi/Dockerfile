FROM microsoft/aspnetcore
FROM heroku/heroku:16
WORKDIR /app
COPY . .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet TodoApi.dll