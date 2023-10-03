using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Infra.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.NomeCompleto).HasColumnType("text");
            builder.HasOne(a => a.Generos).WithMany(g => g.Usuario).HasForeignKey(fk => fk.GeneroId);
            builder.HasMany(a => a.UsuariosCursos).WithOne(uc => uc.User).HasForeignKey(fk => fk.UsuarioId);
            builder.HasMany(a => a.AvaliacoesCursos).WithOne(ac => ac.Usuarios).HasForeignKey(fk => fk.UsuarioId);
        }
    }
}
