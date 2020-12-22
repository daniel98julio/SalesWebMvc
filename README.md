# AlugaHouse
## Tecnologias utilizadas:
Para desenvolver a aplicação foram usadas as seguintes tecnologias:
### Back-End:
- .NetCore 3.1
- Entity Framework Core 3.1
### Front-end:
- Blazor
- Bootstrap
- HTML
### Banco de Dados:
- MySQL

## Dependências:
As seguintes dependências são necessárias para o projeto:
- .NetCore SDK 3.1
- .NetCore Runtime
- MySQL
- git

## Como executar o projeto:
- Clone o repositório https://github.com/daniel98julio/SalesWebMvc.git localmente;
- No Arquivo appsettings.json, ajuste os dados da Connection String para o seu servidor.
- Verifique se a porta 5000 está disponível para ser usada, pois esta será utilizada. Caso não esteja, ajuste para alguma porta que esteja disponível.
### Execute os seguintes comandos: 
- Com o serviço do MySQL ativo, abra o terminal e execute o comando: dotnet ef --startup-project ../AlugaHouse.WebApi database update
- Execute normalmente o projeto no Visual Studio.
- Caso esteja pelo VSCode, execute o comando: dotnet run

### Após tais procedimentos e com os dois serviços rodando, o ambiente estará pronto para ser testado.
- Para acessar a aplicação, utilize o link: http://localhost:5000
