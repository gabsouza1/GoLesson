using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection;

namespace Infra.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    { 
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        }

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