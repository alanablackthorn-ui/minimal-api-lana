# Minimal API – Projeto de estudo com toque pessoal

Projeto desenvolvido acompanhando o curso da DIO sobre ASP.NET Minimal APIs.  
Fiz para estudar, entender melhor o funcionamento de APIs REST e, no caminho, acabei gostando bastante do resultado. 💛

##  Tecnologias
- .NET 8  
- ASP.NET Minimal APIs  
- Entity Framework Core + MySQL  
- Autenticação com JWT  
- Swagger

##  Funcionalidades
- Login com geração de token JWT  
- CRUD de Administradores  
- CRUD de Veículos  
- Paginação  
- Documentação via Swagger  
- Projeto de testes separado

##  Estrutura
- **Api/** → projeto principal  
- **Test/** → testes automatizados  
- **minimal-api.sln** → solução

##  Base de estudo
Esse projeto foi feito seguindo o repositório oficial da DIO:  
https://github.com/digitalinnovationone/minimal-api  
Adaptei para .NET 8 e deixei com a minha cara.

##  Como rodar
1. Configure a connection string no `appsettings.json`  
2. Rode no terminal:
   ```bash
   dotnet restore
   dotnet build
   dotnet run
   
Acesse o Swagger em:
http://localhost:5004/swagger

Feito com carinho durante meus estudos e evolução. 🌼
