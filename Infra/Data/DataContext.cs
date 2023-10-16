using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection;
using Microsoft.AspNetCore.Identity;

namespace Infra.Data
{
    public class DataContext : IdentityDbContext<Usuario, IdentityRole<int>, int>
    { 
        public  DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            //ChangeTracker.AutoDetectChangesEnabled = true;
        }

        public DbSet<AvaliacaoCurso> AvaliacoesCursos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<CursosNiveis> CursosNiveis { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<MateriaCursos> MateriaCursos { get; set; }
        public DbSet<NivelEscolaridade> NivelEscolaridade { get; set; }
        public DbSet<UsuarioCurso> UsuariosCursos { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string conn = "server=localhost;port=3306;database=golesson;user=root;password=admin;Connect Timeout=300";
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            //string conn = "Data Source=localhost;Initial Catalog=GoLesson;Integrated Security=True;TrustServerCertificate=True";
            //optionsBuilder.UseSqlServer(conn);
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.EnableSensitiveDataLogging();
        }

    }
}