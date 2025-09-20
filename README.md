# 🚀 Guia de Instalação e Execução do Projeto Fullstack
Bem-vindo! Este guia detalha todos os passos necessários para configurar e executar o ambiente de desenvolvimento completo, incluindo o backend em .NET e o frontend em Angular.

## ✅ Pré-requisitos
Antes de começar, garanta que tem as seguintes ferramentas instaladas e configuradas na sua máquina:

Git: Para clonar o repositório.

SDK do .NET: (ex: .NET 8.0 ou superior).

Node.js e npm: (Recomenda-se a versão LTS).

Angular CLI: Instalado globalmente (npm install -g @angular/cli).

Docker e Docker Compose: Para executar os serviços em contentores (como a base de dados).

---
## ⚙️ Passos para a Configuração
Siga as instruções abaixo na ordem correta. O backend deve ser iniciado primeiro, pois o frontend depende dele.
### 1. Clone o repositório https://github.com/elizaaguiar/DesafioFast.git

### 2. Configurar e Rodar o Backend (.NET)
Estes passos irão iniciar os serviços Docker (como o MySQL), construir o projeto e aplicar as migrações da base de dados.

 ```
Bash

# 1. Navegue para a pasta do projeto backend
cd DesafioFullstackBackend/DesafioFullstack

# 2. Inicie os contentores Docker (base de dados, etc.)
# O comando "-d" executa em modo "detached" (em segundo plano)
docker compose up -d

# 3. Inicie outro terminal para construir o projeto e garantir que não há erros de compilação
dotnet build

# 4. Aplique as migrações para criar as tabelas na base de dados
dotnet ef database update

# 5. Execute a API do backend
dotnet run
 ```
✨ Pronto! Neste momento, a sua API .NET deverá estar a correr. Geralmente, pode aceder à documentação Swagger em https://localhost:5278/swagger para verificar se está tudo a funcionar. Mantenha este terminal aberto.

### 3. Configurar e Rodar o Frontend (Angular)
Agora, abra um novo terminal e execute os seguintes comandos para iniciar a aplicação Angular.
 ```
Bash

# 1. Navegue de volta para a raiz e entre na pasta do projeto frontend
# (Ajuste o caminho se o nome da pasta for diferente)
cd DesafioFullstackFrontend/Desafio-Fullstack

# 2. Instale todas as dependências do Node.js
npm install

# 3. Inicie o servidor de desenvolvimento do Angular
# O comando "--open" abrirá o seu navegador automaticamente
ng serve --open
 ```
🎉 Sucesso! O seu navegador abrirá automaticamente no endereço http://localhost:4200/workshops, e a aplicação frontend estará a comunicar com o backend que iniciou no primeiro terminal.
