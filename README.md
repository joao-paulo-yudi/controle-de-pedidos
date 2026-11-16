# Controle de Pedidos

Aplicativo desktop para gerenciamento de clientes, produtos e pedidos, desenvolvido em C# com Windows Forms. O sistema permite acompanhar o ciclo de um pedido, administrar seus itens e consultar os registros armazenados em um banco SQL Server.

## Funcionalidades

- Cadastro e autenticação de usuários, com níveis de acesso;
- cadastro de clientes;
- consulta de produtos;
- criação de pedidos e inclusão de itens;
- alteração de quantidades e remoção de itens;
- pesquisa, conclusão e exclusão de pedidos;
- consulta dos itens de cada pedido;
- exportação da listagem de pedidos para arquivo de texto;
- manual do usuário integrado à aplicação.

## Tecnologias

- C#;
- Windows Forms;
- .NET Framework 4.7.2;
- SQL Server;
- ADO.NET, DataSets tipados e TableAdapters;
- Visual Studio.

## Pré-requisitos

- Windows;
- Visual Studio 2017 ou mais recente com a carga de trabalho **Desenvolvimento para desktop com .NET**;
- .NET Framework 4.7.2 Developer Pack;
- uma instância do SQL Server com um banco compatível com os DataSets do projeto.

## Configuração do banco de dados

As conexões utilizadas pela aplicação estão definidas em `Controle de Estoque/App.config` e em `Controle de Estoque/Properties/Settings.settings`.

Antes de executar o projeto:

1. Disponibilize um banco SQL Server com as tabelas esperadas pela aplicação, como `Usuarios`, `Clientes`, `Produtos`, `Pedidos`, `Itens_Pedido` e `Itens_Temp`.
2. Substitua as connection strings existentes pelos dados da sua instância.
3. Confirme que o usuário do banco possui permissão para consultar, inserir, atualizar e excluir registros.

Exemplo usando autenticação integrada do Windows:

```xml
<add name="Controle_de_Estoque.Properties.Settings.ControleDePedidosConnectionString"
     connectionString="Data Source=SEU_SERVIDOR;Initial Catalog=ControleDePedidos;Integrated Security=True"
     providerName="System.Data.SqlClient" />
```

> Não versionar senhas ou outras credenciais reais. Caso uma credencial já tenha sido publicada, ela deve ser revogada e substituída.

## Como executar

1. Clone o repositório:

   ```powershell
   git clone <URL_DO_REPOSITORIO>
   cd controle-de-pedidos
   ```

2. Abra `Controle de Pedidos.sln` no Visual Studio.
3. Confira a configuração do banco de dados.
4. Defina **Controle de Estoque** como projeto de inicialização, se necessário.
5. Compile e execute com `F5`.

Também é possível compilar pelo Developer PowerShell do Visual Studio:

```powershell
msbuild "Controle de Pedidos.sln" /p:Configuration=Debug
```

O executável será gerado em `Controle de Estoque/bin/Debug/Controle de Pedidos.exe`.

## Estrutura do projeto

```text
controle-de-pedidos/
├── Controle de Pedidos.sln
└── Controle de Estoque/
    ├── Classes/       # Estado compartilhado entre telas
    ├── Controles/     # Controles, diálogos e manual do usuário
    ├── Dados/         # DataSets tipados de acesso ao banco
    ├── Forms/         # Telas da aplicação
    ├── Mídia/         # Imagens utilizadas pela interface
    ├── Resources/     # Recursos incorporados
    ├── App.config     # Configurações e conexões
    └── Program.cs     # Ponto de entrada da aplicação
```

## Observações

- O projeto não inclui scripts para criar ou popular o banco de dados; é necessário fornecer uma base compatível.
- A aplicação foi criada para o .NET Framework clássico e, portanto, não é multiplataforma.
- Não há uma licença de uso definida neste repositório.
