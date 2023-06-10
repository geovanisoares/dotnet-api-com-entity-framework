# dotnet-api-com-entity-framework

Este é um projeto de exemplo que demonstra como criar uma API usando o ASP.NET Core e o Entity Framework. Ele fornece uma estrutura básica para construir um serviço da Web usando o padrão RESTful.

### Pré-requisitos:

Antes de executar este projeto, verifique se você tem os seguintes pré-requisitos:

- SDK do .NET 6 (ou superior)

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
- PATCH /api/produtos/{id}: Atualiza os dados específicos de um produto existente.
- DELETE /api/produtos/{id}: Exclui um produto.

### Contribuindo

Se você quiser contribuir para este projeto, siga estas etapas:

- Fork este repositório.
- Crie uma nova branch: git checkout -b minha-nova-feature
- Faça suas alterações e confira se tudo está funcionando corretamente.
- Envie suas alterações: git commit -m 'Adicionando nova feature'
- Envie a branch: git push origin minha-nova-feature
- Abra um Pull Request.

### Contato:

Se você tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato comigo através do email servico.websoares@gmail.com
