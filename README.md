# Projeto BurguerMania - API Backend para Gerenciamento de Pedidos

## Modelo do Banco de Dados
Abaixo está a imagem do Modelo do banco de dados do projeto BurguerMania:

![Modelo do banco de dados do projeto BurguerMania](https://github.com/user-attachments/assets/4f3895a1-be26-4c5d-a8bf-71b2ec54be31)

## Descrição do Projeto
O **BurguerMania API** é a continuação do projeto Frontend desenvolvido em Angular, que tem como objetivo proporcionar uma experiência completa no gerenciamento de pedidos de hambúrguer. Este projeto backend foi desenvolvido utilizando o **.NET** e o **Entity Framework** para implementar uma API seguindo o padrão REST, que serve como base para armazenar e processar dados de categorias, produtos e pedidos.

A API foi projetada para atender todos os requisitos do Frontend, garantindo que as operações de CRUD possam ser realizadas de forma eficiente e organizada.

## Funcionalidades
- **Gerenciamento de Categorias**:
  - Criar, listar, atualizar e deletar categorias de hambúrgueres.
- **Gerenciamento de Produtos**:
  - Criar, listar, atualizar e deletar produtos relacionados às categorias.
- **Gerenciamento de Pedidos**:
  - Criar e listar pedidos, permitindo adicionar produtos e observações aos pedidos.

## Instruções para Executar a API
1. **Clone o repositório**:
   ```bash
   git clone https://github.com/eduardolopesx03/Projeto-Backend
   ```

2. **Navegue até o diretório do projeto**:
   ```bash
   cd Projeto-Backend-master
   ```

3. **Configure o Banco de Dados**:
   - Certifique-se de ter o **PostgreSQL** instalado e rodando.
   - Crie um banco de dados vazio chamado `BurguerMania`.
   - Atualize a string de conexão no arquivo `appsettings.json`, caso necessário:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Database=BurguerMania;Username=postgres;Password=1234"
     }
     ```

4. **Execute as Migrações**:
   - Aplique as migrações para configurar o banco de dados:
     ```bash
     dotnet ef database update
     ```

5. **Execute a API**:
   - Inicie o servidor da API:
     ```bash
     dotnet run
     ```

6. **Teste a API**:
   - Acesse o Swagger para testar os endpoints:
     [http://localhost:7007/swagger](http://localhost:7007/swagger)

## Tecnologias Utilizadas
- **.NET**: Framework utilizado para o desenvolvimento do backend.
- **Entity Framework Core**: Ferramenta ORM para gerenciar o banco de dados.
- **PostgreSQL**: Banco de dados relacional utilizado para armazenar os dados.
- **Swagger**: Interface para documentação e teste dos endpoints da API.
- **C#**: Linguagem de programação utilizada no desenvolvimento.

## Estrutura do Projeto
- **Controllers**:
  - Controladores responsáveis por gerenciar as requisições para categorias, produtos e pedidos.
- **Models**:
  - Classes que representam as entidades principais do projeto, como `Category`, `Product` e `Order`.
- **Data**:
  - Contexto do Entity Framework para gerenciar a conexão e manipulação de dados no banco.
- **Program.cs**:
  - Configuração inicial do projeto e registro dos serviços.

## Endpoints Principais
- **Categorias**:
  - `GET /api/Categories` - Listar todas as categorias.
  - `POST /api/Categories` - Criar uma nova categoria.
  - `PUT /api/Categories/{id}` - Atualizar uma categoria existente.
  - `DELETE /api/Categories/{id}` - Deletar uma categoria.

- **Produtos**:
  - `GET /api/Products` - Listar todos os produtos.
  - `POST /api/Products` - Criar um novo produto.
  - `PUT /api/Products/{id}` - Atualizar um produto existente.
  - `DELETE /api/Products/{id}` - Deletar um produto.

- **Pedidos**:
  - `GET /api/Orders` - Listar todos os pedidos.
  - `POST /api/Orders` - Criar um novo pedido.

## Possíveis Melhorias Futuras
Embora a API atenda a todos os requisitos do projeto BurguerMania Frontend desenvolvido em Angular, houve desafios durante o processo de integração da API com o Frontend devido à falta de familiaridade e por ser o meu primeiro projeto Full Stack.

Por isso, não foi possível realizar a integração completa da API ao Frontend no prazo disponível. Futuramente, pretendo:
- Criar uma nova branch no projeto Frontend e realizar a integração completa com a API.
- Adicionar autenticação e autorização na API para maior segurança.
- Melhorar a organização do código e adicionar testes automatizados para validar as funcionalidades.

## Links
- **Repositório Frontend**: https://github.com/eduardolopesx03/Projeto-Frontend
- **Swagger**: [http://localhost:7007/swagger](http://localhost:7007)
