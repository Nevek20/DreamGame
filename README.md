# Dream Game

Aplicação desktop para cadastro de jogos em um banco de dados MySQL. Feita em C# com Windows Forms, permite preencher os dados de um jogo e salvá-los na tabela `tb_games` com um clique.

![C#](https://img.shields.io/badge/C%23-.NET%20Framework%204.7.2-512BD4)
![MySQL](https://img.shields.io/badge/MySQL%2FMariaDB-10.4-4479A1)
![Licença](https://img.shields.io/badge/licen%C3%A7a-MIT-green)

## Sumário

- [Funcionalidades](#funcionalidades)
- [Tecnologias](#tecnologias)
- [Estrutura do projeto](#estrutura-do-projeto)
- [Pré-requisitos](#pré-requisitos)
- [Instalação e execução](#instalação-e-execução)
- [Configuração do banco](#configuração-do-banco)
- [Como usar](#como-usar)
- [Campos do formulário](#campos-do-formulário)
- [Limitações conhecidas](#limitações-conhecidas)
- [Próximos passos](#próximos-passos)
- [Licença](#licença)

## Funcionalidades

- Cadastro de jogos com título, avaliação, tamanho, descrição, valor, desenvolvedor e gênero
- Campos com máscara para padronizar avaliação, tamanho e valor
- Inserção no MySQL com consultas parametrizadas (protege contra SQL Injection)
- Botão **Limpar campo** para resetar o formulário
- Mensagem de sucesso ou de erro após cada tentativa de envio

## Tecnologias

| Item | Detalhe |
| --- | --- |
| Linguagem | C# |
| Interface | Windows Forms |
| Plataforma | .NET Framework 4.7.2 |
| Banco de dados | MySQL / MariaDB (dump gerado no MariaDB 10.4.32) |
| Driver | MySql.Data 9.2.0 (via NuGet) |
| IDE recomendada | Visual Studio 2019 ou 2022 |

## Estrutura do projeto

```
DreamGame/
├── bd_jogos.sql              # Script do banco (tabela tb_games)
├── dream game.sln            # Solução do Visual Studio
├── LICENSE.txt               # Licença MIT
└── dream game/
    ├── Program.cs            # Ponto de entrada da aplicação
    ├── Form1.cs              # Lógica do formulário (inserir e limpar)
    ├── Form1.Designer.cs     # Layout gerado pelo designer
    ├── Form1.resx            # Recursos do formulário
    ├── App.config            # Configuração do runtime
    ├── packages.config       # Pacotes NuGet
    ├── dream game.csproj     # Arquivo do projeto
    └── Properties/           # Metadados e recursos do assembly
```

## Pré-requisitos

- Windows
- [Visual Studio](https://visualstudio.microsoft.com/) com a carga de trabalho **Desenvolvimento para desktop com .NET**
- .NET Framework 4.7.2 (Developer Pack)
- Um servidor MySQL ou MariaDB rodando em `localhost:3306` (o [XAMPP](https://www.apachefriends.org/) resolve)

## Instalação e execução

1. Clone o repositório:

   ```bash
   git clone https://github.com/<seu-usuario>/DreamGame.git
   cd DreamGame
   ```

2. Configure o banco de dados (veja a seção abaixo).
3. Abra o arquivo `dream game.sln` no Visual Studio.
4. Restaure os pacotes NuGet (clique direito na solução e **Restaurar Pacotes NuGet**, ou deixe o Visual Studio fazer isso ao compilar).
5. Pressione **F5** para compilar e executar.

## Configuração do banco

O script `bd_jogos.sql` cria apenas a tabela e **não cria o banco**, então crie-o antes de importar.

1. Inicie o MySQL/MariaDB (no XAMPP, ative o módulo **MySQL**).
2. Crie o banco e importe o script:

   ```sql
   CREATE DATABASE bd_jogos CHARACTER SET utf8mb4;
   ```

   ```bash
   mysql -u root bd_jogos < bd_jogos.sql
   ```

   Pelo phpMyAdmin: crie o banco `bd_jogos`, entre nele, vá em **Importar** e selecione o `bd_jogos.sql`.

### Estrutura da tabela `tb_games`

| Coluna | Tipo | Observação |
| --- | --- | --- |
| `Id` | `int(11)` | Chave primária, auto incremento |
| `Titulo` | `varchar(255)` | |
| `Avaliacao` | `varchar(2)` | |
| `Tamanho` | `varchar(5)` | |
| `Descricao` | `varchar(255)` | |
| `Valor` | `varchar(8)` | |
| `Desenvolvedor` | `varchar(100)` | |
| `Genero` | `varchar(30)` | |

### String de conexão

A conexão está definida direto no `Form1.cs`, no evento do botão **Enviar**:

```csharp
string conexaoString = "Server=localhost; Port=3306; Database=bd_jogos; Uid=root; Pwd=;";
```

Se o seu MySQL usa outra porta, usuário ou senha, altere essa linha antes de compilar.

## Como usar

1. Execute a aplicação.
2. Preencha os campos do formulário.
3. Clique em **Enviar** para gravar o jogo no banco. Uma mensagem confirma o sucesso e os campos são limpos.
4. Clique em **Limpar campo** a qualquer momento para apagar tudo e voltar o foco para o título.

## Campos do formulário

| Campo | Controle | Máscara | Exemplo |
| --- | --- | --- | --- |
| Título | TextBox | nenhuma | `The Witcher 3` |
| Avaliação | MaskedTextBox | `00` | `95` |
| Tamanho | MaskedTextBox | `000GB` | `050GB` |
| Descrição | RichTextBox | nenhuma | `RPG de mundo aberto...` |
| Valor | MaskedTextBox | `$000.00` | `$059.90` |
| Desenvolvedor | TextBox | nenhuma | `CD Projekt Red` |
| Gênero | TextBox | nenhuma | `RPG` |

## Limitações conhecidas

- A aplicação só **insere** registros. Ainda não há listagem, edição ou exclusão.
- Não há validação de campos vazios antes do envio.
- A string de conexão (com usuário `root` e senha vazia) está fixa no código. Serve para desenvolvimento local, mas não deve ir para produção.
- `Avaliacao`, `Tamanho` e `Valor` são salvos como texto (`varchar`), o que impede ordenar ou somar por esses campos.
- O `bd_jogos.sql` traz um registro de teste (`asdasd`) que pode ser apagado.
- O título da janela ainda é o padrão `Form1`.

## Licença

Distribuído sob a licença MIT. Veja o arquivo [LICENSE.txt](LICENSE.txt) para mais detalhes.
