# AcademiaProjectoWebApiNetCore6

- Web API ASPNET Core 6.0
- EF Core

## Requisitos
- Visual Studio
- Pacotes
  - EntityFrameworkeCore
  - EntityFrameworkeCore.design
  - EntityFrameworkeCore.SqlServer
  - EntityFrameworkeCore.Tools

## Pastas
- 1.UI
- 2.WebApi
  - AcademiaProjeto.WebApi
- 3.Domain
  - AcademiaProjeto.Domain
- 4.Repository
  - AcademiaProjeto.Repositories
- 5.Data
  - AcademiaProjeto.Data

## Conexão da base dados

## Passo a passo
- Criação do projeto web api ASPNET Core .Net6
- Criação da biblioteca de classe AcademiaProjeto.Data
  - Instalação dos pacotes do entity framework core
  - Criação da pasta Context
  - Criação da classe DataContext
  - override do método OnModelCreating na classe DataContext
    - setando as entidades que fazem parte modelBuilder.Entity<Curso>(new CursoConfiguration().Configure);
  - Criação da classe CursoConfiguration
    - Implementando interface IEntityTypeConfiguration<Curso>
	- override do método Configure que detalha as colunas da tabela curso
- Criação da biblioteca de classe AcademiaProjeto.Domain  
  - Criação da pasta Entities
  - Criação da classe Curso
- Criação do biblioteca de classe AcademiaProjeto.Repository
  - Criação da pasta Base
	- Criação da interface IBaseRepository<T> where T : class com as assinaturas do metodos
    - Criação da classe BaseRepository<T> : IBaseRepository<T> where T : class
	- Implentação dos métodos genéricos na classe
  - Criação da pasta Interface
    - Criação da interface  ICursoRepository : IBaseRepository<Curso>
  - Criação da Pasta Repository  
    - Criação da classe CursoRepository : BaseRepository<Curso>, ICursoRepository e seu construtor recebendo DataContext
- Edição do appSettings.json
  - Adicionada "ConnectionStrings" : { "DefaultConnection" : "Data Source=localhost
- Edição Program.cs. Adicionado carregamento da string de conexão string strConnection = builder.Configuration.GetConnectionString("DefaultConnection");
  - Adicionada Injeção builder.Services.AddDbContext<DataContext>(option => 
{
    option.UseSqlServer(strConnection);
});
  - builder.Services.AddScoped<ICursoRepository, CursoRepository>();
- Console Gerenciador de Pacotes: add-migration CreateTableCursos
- Console Gerenciador de Pacotes: update-database
- Execução da API