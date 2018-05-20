FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine
WORKDIR /app
COPY . .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet cv.dll