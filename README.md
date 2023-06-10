# dotnet-api-com-entity-framework

Este é um projeto de exemplo que demonstra como criar uma API usando o ASP.NET Core e o Entity Framework. Ele fornece uma estrutura básica para construir um serviço da Web usando o padrão RESTful.

### Pré-requisitos:

Antes de executar este projeto, verifique se você tem os seguintes pré-requisitos:

- SDK do .NET Core (versão 3.1 ou superior)
- SQL Server ou SQL Server Express (ou você pode usar outro banco de dados compatível com o Entity Framework)

### Configuração

Siga as etapas abaixo para configurar e executar o projeto:

Clone este repositório em sua máquina local:

~~~bash
git clone https://github.com/geovanisoares/dotnet-api-com-entity-framework.git
~~~

Acesse o diretório do projeto:

~~~bash
cd dotnet-api-com-entity-framework
~~~

Abra o arquivo appsettings.json e atualize a string de conexão com seu banco de dados SQL Server:

~~~~json
"ConnectionStrings": {
    "DefaultConnection": "Server=<nome do servidor>;Database=<nome do banco de dados>;Trusted_Connection=True;"
}
~~~~

No terminal, execute o seguinte comando para criar o banco de dados e executar as migrações:

~~~~sql
dotnet ef database update
~~~~

Agora você pode iniciar a API. Execute o seguinte comando:

~~~~
dotnet run
~~~~

A API estará disponível em http://localhost:5000 ou https://localhost:5001.

### Endpoints

A API oferece os seguintes endpoints:

- GET /api/produtos: Retorna uma lista de todos os produtos.
- GET /api/produtos/{id}: Retorna os detalhes de um produto específico.
- POST /api/produtos: Cria um novo produto.
- PUT /api/produtos/{id}: Atualiza os dados de um produto existente.
- DELETE /api/produtos/{id}: Exclui um produto.

### Contribuindo

Se você quiser contribuir para este projeto, siga estas etapas:

- Fork este repositório.
- Crie uma nova branch: git checkout -b minha-nova-feature
- Faça suas alterações e confira se tudo está funcionando corretamente.
- Envie suas alterações: git commit -m 'Adicionando nova feature'
- Envie a branch: git push origin minha-nova-feature
- Abra um Pull Request.

### Licença

Este projeto está licenciado sob a Licença MIT. Consulte o arquivo LICENSE para obter mais detalhes.

### Contato:

Se você tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato comigo através do email servico.websoares.com.br
