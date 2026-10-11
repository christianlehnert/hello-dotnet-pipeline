# The application is published once in the pipeline (dotnet publish ... --output publish)
# and copied into the image. ASP.NET Core images listen on port 8080 by default.
FROM mcr.microsoft.com/dotnet/aspnet:10.0

WORKDIR /app
COPY publish/ .

USER $APP_UID
EXPOSE 8080
ENTRYPOINT ["dotnet", "HelloDotnet.dll"]
