# DotNetCoreArchitecture

Architecture using new technologies and best practices to share knowledge and be used in new projects.

[![Codacy](https://api.codacy.com/project/badge/Grade/7f33404bab084b84aacac5800fd107fc)](https://app.codacy.com/project/rafaelfgx/DotNetCoreArchitecture/dashboard)
[![Gitter](https://badges.gitter.im/rafaelfgx/DotNetCoreArchitecture.svg)](https://gitter.im/rafaelfgx/DotNetCoreArchitecture)

## Technologies

* [.NET Core 2.2](https://dotnet.microsoft.com/download)
* [C# 7.3](https://docs.microsoft.com/en-us/dotnet/csharp)
* [ASP.NET Core 2.2](https://docs.microsoft.com/en-us/aspnet/core)
* [Entity Framework Core 2.2](https://docs.microsoft.com/en-us/ef/core)
* [Angular 7.2](https://angular.io/docs)
* [Typescript 3.1](https://www.typescriptlang.org/docs/home.html)
* [HTML](https://www.w3schools.com/html)
* [CSS](https://www.w3schools.com/css)
* [SASS](https://sass-lang.com)
* [UIkit](https://getuikit.com/docs/introduction)
* [JWT](https://jwt.io)
* [Swagger](https://swagger.io)
* [Docker](https://docs.docker.com)

## Practices

* Clean Code
* Ubiquitous Language
* DDD (Domain-Driven Design)
* SOLID Principles
* KISS Principle (Keep it simple, stupid)
* DRY Principle (Don't repeat yourself)
* YAGNI Principle (You aren't gonna need it)
* Without Over-Engineering
* Inversion of Control
* Dependency Injection
* Object Mapping
* Logging
* Response Caching
* Response Compression
* Code Analysis
* Cross-Platform

## Nuget Packages

* Source: [https://github.com/rafaelfgx/DotNetCore](https://github.com/rafaelfgx/DotNetCore)
* Published: [https://www.nuget.org/profiles/rafaelfgx](https://www.nuget.org/profiles/rafaelfgx)

## Tools

* [Visual Studio 2017](https://visualstudio.microsoft.com/vs)
* [Visual Studio Code](https://code.visualstudio.com)
* [SQL Server 2017](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Layers

![Screenshot](screenshots/layers.png)

**Web:** This layer contains the api (ASP.NET Core) and the frontend (Angular).

**Application:** This layer is the main entry point of the application.

**Domain:** This layer contains the requirements and the business logic.

**Model:** This layer is responsible for modeling the domain objects.

**Database:** This layer isolates and abstracts the logic for data persistence.

**CrossCutting:** This layer provides generic features for other layers.

**IoC:** This layer provides inversion of control for other layers.

## Projects

![Screenshot](screenshots/projects.png)

## Microservices Example

![Screenshot](screenshots/microservices.png)

## Application

![Screenshot](screenshots/layer-application.png)

## Domain

![Screenshot](screenshots/layer-domain.png)

## Repository

![Screenshot](screenshots/layer-repository.png)

## ASP.NET Core + Angular

![Screenshot](screenshots/aspnetcore-angular.png)

## ASP.NET Core Startup

![Screenshot](screenshots/aspnetcore-startup.png)

## ASP.NET Core Controller

![Screenshot](screenshots/aspnetcore-controller.png)

## Angular Guard

![Screenshot](screenshots/angular-guard.png)

## Angular Error Handler

![Screenshot](screenshots/angular-error-handler.png)

## Angular HTTP Interceptor

![Screenshot](screenshots/angular-http-interceptor.png)

## Angular Service

![Screenshot](screenshots/angular-service.png)

## Angular Component

![Screenshot](screenshots/angular-component.png)

## Performance

![Screenshot](screenshots/aspnetcore-angular-performance.png)

## Specifications

**Processor:** Intel Core I7 8700K Coffee Lake 8th-generation.

**Memory:** 16GB 2400Mhz DDR4.

**Storage:** Samsung Evo 960 SSD M2 250gb.

**OS:** Windows 10 Pro 64 bits.

**Web Server:** Kestrel.

**Database:** SQL Server 2017 Developer Edition.

## Swagger

![Screenshot](screenshots/swagger.png)

## Run Command Line

1. Install latest [.NET Core SDK](https://aka.ms/dotnet-download).

2. Open directory **source\Web\Frontend** in command line and execute **npm run restore**.

3. Open directory **source\Web** in command line and execute **dotnet run**.

4. Open <https://localhost:8090>.

## Run Visual Studio Code

1. Install latest [.NET Core SDK](https://aka.ms/dotnet-download).

2. Install [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp).

3. Open directory **source\Web\Frontend** in command line and execute **npm run restore**.

4. Open **source** directory in Visual Studio Code.

5. Press **F5**.

## Run Visual Studio 2017

1. Install latest [.NET Core SDK](https://aka.ms/dotnet-download).

2. Open directory **source\Web\Frontend** in command line and execute **npm run restore**.

3. Open **source\DotNetCoreArchitecture.sln** in Visual Studio.

4. Set **DotNetCoreArchitecture.Web** as startup project.

5. Press **F5**.

## Run Docker

1. Install and configure [Docker](https://www.docker.com/get-started).

2. Execute **docker-compose up --build -d --force-recreate** in root directory.

3. Open <http://localhost:8095>.

## Visual Studio Extensions

[CodeMaid](https://marketplace.visualstudio.com/items?itemName=SteveCadwallader.CodeMaid)

[Roslynator](https://marketplace.visualstudio.com/items?itemName=josefpihrt.Roslynator2017)

[SonarLint](https://marketplace.visualstudio.com/items?itemName=SonarSource.SonarLintforVisualStudio2017)

[TSLint](https://marketplace.visualstudio.com/items?itemName=vladeck.TSLint)
