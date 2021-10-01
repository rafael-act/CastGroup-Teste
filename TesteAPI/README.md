<h1 align="center">
     💻 <a href="#" alt="CastGroup-Teste"> CastGroup-Teste </a>
</h1>

<h3 align="center">
    Teste prático CastGroup
</h3>

<p align="center">
    <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/rafael-act/CastGroup-Teste?color=%2304D361">

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/rafael-act/CastGroup-Teste">

  <a href="https://www.twitter.com/rafael_act/">
    <img alt="Siga no Twitter" src="https://img.shields.io/twitter/url?url=https%3A%2F%2Fgithub.com%2Frafael-act%2FCastGroup-Teste">
  </a>
  
  <a href="https://github.com/rafael-act/CastGroup-Teste/commits/master">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/rafael-act/CastGroup-Teste">
  </a>
    
   <img alt="License" src="https://img.shields.io/badge/license-MIT-brightgreen">
   <a href="https://github.com/rafael-act/CastGroup-Teste/stargazers">
    <img alt="Stargazers" src="https://img.shields.io/github/stars/rafael-act/CastGroup-Teste?style=social">
  </a>
</p>

<h4 align="center">
	🚧   Concluído 🚀 🚧
</h4>

---

## 💻 Sobre o projeto

Criar uma API Rest que permita realizar as operações CRUD (criar, recuperar/consultar, editar e excluir) de Cursos para turmas de formação do Cast group.

---

## ⚙️ Solução

- [x] Esta solução possui 3 projetos:
  - [x] TesteAPI - Projeto do tipo api que receberá as requisições para os serviços
    - [x] Controllers
      - CursoController
      - CategoriaController 
  - [x] TesteAPI.Dominio - Projeto responsável pela implementação de classes/modelos, as quais serão mapeadas para o banco de dados, além de obter as declarações de interfaces.
    - [x] Contratos
      - IBaseRepositorio - Interface com metodos de crud
      - ICategoriaRepositorio - Interface com metodos de categoria
      - ICursoRepositorio - Interface com metodos de curso
    - [x] Entidades
      - Entidade - Entidade padrão do sistema
      - Categoria - Classe categoria
      - Curso - Classe curso
  - [x] TesteAPI.Repositorio - A camada de repositório é implementada para acessar o banco de dados e ajuda a estender as operações CRUD no banco de dados.
    - [x] Config - Pasta com os arquivos de configuração do Entity Framework para criação da base de dados
      - CategoriaConfiguration
      - CursoConfiguration
    - [x] Contexto - O contexto onde estarão as entidades. Todas as mudanças feitas no contexto não serão persistidas no banco de dados.
      - CastGroupContexto
    - [x] Migrations - Diretório onde é armazenado o versionamento do schema da aplicação.
    - [x] Repositorios - Pasta com Classes com implementação dos métodos de manipulação de dados no contexto  
      - BaseRepositorio
      - CategoriaRespositorio
      - CursoRespositorio

#### **Autenticação e Autorização** 

-   **Autenticação e Autorização com Bearer e JWT**
-   Acesse o controller /api/Login/login usuario: cast senha: abc123
---

## 🛠 Critérios de aceite

#### **Banco de dados** 

-   **Foi utilizado o MySQL com Entity Framework e o Migrations no modelo code first para criação da base**
-   **As categorias foram criadas na configuração da base no arquivo [TesteAPI.Repositorio\Contexto\CastGroupContexto.cs](https://github.com/rafael-act/CastGroup-Teste/blob/main/TesteAPI/TesteAPI.Repositorio/Contexto/CastGroupContexto.cs)**

#### **Regras de negócio** 

-   **a) não será permitida inclusão de curso no mesmo período R: [TesteAPI.Repositorio\Repositorio\CursoRespositorio.cs](https://github.com/rafael-act/CastGroup-Teste/blob/main/TesteAPI/TesteAPI.Repositorio/Repositorios/CursoRespositorio.cs)**
-   **b)Não será permitida a inclusão de cursos com a data de início menor que a data atual. R: [TesteAPI.Dominio/Entidades/Curso.cs](https://github.com/rafael-act/CastGroup-Teste/blob/main/TesteAPI/TesteAPI.Dominio/Entidades/Curso.cs)**

#### **API Rest**

-   **Deve-se disponibilizar um endpoint com a interface do Swagger para fácil visualização das operações disponíveis. R: [Startup](https://github.com/rafael-act/CastGroup-Teste/blob/main/TesteAPI/TesteAPI/Startup.cs)**

---

## 🦸 Autor

<a href="https://rafaelcastro.com.br">
 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/48982662?s=100&v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Rafael Castro</b></sub></a> <a href="https://rafaelcastro.com.br" title="Rafael">🚀</a>
 <br />

---

## 📝 Licença

Este projeto esta sobe a licença [MIT](./LICENSE).

Feito com ❤️ por Rafael Castro 👋🏽 [Entre em contato!](https://www.linkedin.com/in/rafaelcastrodev/)

---
