#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1809 AS base
FROM mcr.microsoft.com/dotnet/core/runtime
WORKDIR /app
EXPOSE 80

COPY ./bin/Release/netcoreapp3.1/publish .
ENTRYPOINT ["dotnet", "WebApplication2.dll"]