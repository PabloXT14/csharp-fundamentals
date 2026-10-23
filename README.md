# C# Fundamentals

Projeto de estudos com exercícios introdutórios de C# e .NET. A aplicação é executada no terminal e cada exercício demonstra um conceito básico da linguagem por meio de entradas e saídas interativas.

## Requisitos

- [.NET SDK 10.0](https://dotnet.microsoft.com/download/dotnet/10.0) ou superior

Confira a versão instalada:

```bash
dotnet --version
```

## Como executar

Na raiz do repositório, restaure as dependências e execute o projeto:

```bash
dotnet restore
dotnet run --project src/CsharpFundamentals.App/CsharpFundamentals.App.csproj
```

Para compilar sem executar:

```bash
dotnet build
```

## Exercícios

Os exercícios estão em [`src/CsharpFundamentals.App/Exercises`](src/CsharpFundamentals.App/Exercises):

| Exercício | Conceitos praticados |
| --- | --- |
| `Exercise01` | Leitura de nome e interpolação de strings |
| `Exercise02` | Leitura de nome e sobrenome e composição de strings |
| `Exercise03` | Operações matemáticas, métodos, tuplas e tratamento de divisão por zero |
| `Exercise04` | Manipulação de texto e contagem de caracteres |
| `Exercise05` | Validação do formato de placas de veículos |
| `Exercise06` | Formatação de datas e horários com cultura `pt-BR` |

## Selecionando um exercício

O exercício executado é definido em [`Program.cs`](src/CsharpFundamentals.App/Program.cs). Atualmente, o projeto instancia e executa `Exercise06`:

```csharp
var exercise06 = new Exercise06();
exercise06.Execute();
```

Para executar outro exercício, altere a instância correspondente. Por exemplo:

```csharp
var exercise03 = new Exercise03();
exercise03.Execute();
```

Depois, execute novamente:

```bash
dotnet run --project src/CsharpFundamentals.App/CsharpFundamentals.App.csproj
```

## Estrutura do projeto

```text
.
├── CsharpFundamentals.slnx
├── src/
│   └── CsharpFundamentals.App/
│       ├── CsharpFundamentals.App.csproj
│       ├── Program.cs
│       └── Exercises/
│           ├── Exercise01.cs
│           ├── Exercise02.cs
│           ├── Exercise03.cs
│           ├── Exercise04.cs
│           ├── Exercise05.cs
│           └── Exercise06.cs
└── README.md
```

## Tecnologias

- C#
- .NET 10
- Aplicação de console
