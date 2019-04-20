FROM microsoft/dotnet:lastest
WORKDIR /app
COPY /. /app
RUN dotnet restore
RUN dotnet publish -o /out -c Release
EXPOSE 5500
ENTRYPOINT ["dotnet","/out/GenJii.dll"]