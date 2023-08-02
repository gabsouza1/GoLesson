using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection;
using Microsoft.AspNetCore.Identity;

namespace Infra.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    { 
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        }

        public DbSet<Arquivo> Arquivos { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<AvaliacaoCurso> AvaliacoesCursos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<CodigoPostal> CodigoPostal { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Favorito> Favoritos { get; set; }
        public DbSet<FormaPagamento> FormasPagamentos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<NotaAvaliacao> NotasAvaliacoes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<StatusPagamento> StatusPagamentos { get; set; }
        public DbSet<UsuarioCurso> UsuariosCursos { get; set; }
        public DbSet<UsuarioModulo> UsuariosModulos { get; set; }
        
       


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(GetConnectionString());
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.EnableSensitiveDataLogging();
        }

        private string GetConnectionString()
        {
            var conn = "Data Source=DESKTOP-KU3D3B1;Initial Catalog=GoLesson;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=true;";
            return conn;
        }
    }
}