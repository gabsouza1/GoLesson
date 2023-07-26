using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    public class AppliactionUserMapping : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("Generos");
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Generos).WithMany(x => x.User).HasForeignKey(x => x.GeneroId);
            builder.HasMany(p => p.UsuariosCursos).WithOne(x => x.User).HasForeignKey(x => x.UsuarioId);
            builder.Property(p => p.Foto).HasColumnName("Foto").HasColumnType("varchar").HasMaxLength(255);


        }
    }
}
