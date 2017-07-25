### PROVA PRÁTICA ###

# TECNOLOGIAS EMPREGADAS NO BACK-END:
- C#;
-.NET 4.6.1;
- ASP.NET Web API Core;
- EntityFramework Core (CodeFirst);
- SQL Server;
- Swagger - documentação e testes das Web APIs

# PRÉ-REQUISITOS
- Visual Studio 2017
- .NET Framework 1.1

# Rodar o back-end em self-host

Após clonar o projeto na máquina, os seguintes passos devem ser seguidos:

1 - Entrar no diretótio raiz do projeto via Prompt de comando "CMD-DOS" (..\HBSIS-back-end\src\HBSIS.Services.Api) e digitar o seguinte comando:

# dotnet restore

2 - Após o término do restore digite o seguinte comando:

# dotnet run

A mensagem após a execução do comenado assima deverá ter como resultado o seguinte output no Prompt: 

Hosting environment: Production
Content root path: ..\HBSIS-back-end\src\HBSIS.Services.Api
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
