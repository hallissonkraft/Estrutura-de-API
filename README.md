# Estrutura-de-API
# Exo Web API

Este repositório contém uma aplicação Web API desenvolvida em .NET 6 como parte de uma atividade prática.  
O projeto implementa um CRUD básico de projetos utilizando o Entity Framework Core e o banco de dados SQL Server Express.

---

## Sobre o Projeto

A aplicação permite cadastrar, listar, atualizar e excluir registros de projetos.  
O objetivo é demonstrar o funcionamento de uma API REST em C# com acesso a banco de dados relacional.

---

## Tecnologias Utilizadas

- .NET 6
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server Express
- Visual Studio ou VS Code

---

## Estrutura do Projeto

Exo.WebApi
┣ Contexts
┃ ┗ ExoContext.cs
┣ Controllers
┃ ┗ ProjetosController.cs
┣ Models
┃ ┗ Projeto.cs
┣ Properties
┃ ┗ launchSettings.json
┣ appsettings.json
┣ Program.cs
┗ README.md


## Configuração do Banco de Dados

O projeto utiliza o SQL Server Express local.

### String de Conexão

```csharp
optionsBuilder.UseSqlServer(
    "Server=DESKTOP-N1ATTAE\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"
);
Se o nome do seu servidor for diferente, altere o valor de Server= conforme o nome exibido no SQL Server Management Studio (SSMS).

Criação do Banco
Crie o banco manualmente ou via Entity Framework:

sql

CREATE DATABASE ExoApi;
Ou usando migrações:

bash

dotnet ef migrations add InitialCreate
dotnet ef database update
Como Executar
Clone o repositório:

bash

git clone https://github.com/SEU-USUARIO/exo-webapi.git
cd exo-webapi
Restaure as dependências:

bash

dotnet restore
Execute o projeto:

bash

dotnet run
Acesse a API nos endereços:

https://localhost:7154

http://localhost:5038

Se o navegador indicar que o site é inseguro, execute o comando:

bash

dotnet dev-certs https --trust
Endpoints
Método	Endpoint	Descrição
GET	/api/projetos	Lista todos os projetos
GET	/api/projetos/{id}	Busca um projeto pelo ID
POST	/api/projetos	Cadastra um novo projeto
PUT	/api/projetos/{id}	Atualiza um projeto existente
DELETE	/api/projetos/{id}	Remove um projeto

Exemplo de JSON (POST)
json

{
  "nome": "API de Exemplo",
  "descricao": "Primeira atividade prática com .NET e EF Core"
}
Licença
Projeto desenvolvido para fins educacionais.
Pode ser utilizado e modificado livremente.


