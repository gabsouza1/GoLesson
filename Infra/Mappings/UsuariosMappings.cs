
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Entities;

namespace Infra.Mappings
{
    public class UsuariosMapping : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(255).IsRequired();
            builder.Property(p => p.SobreNome).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Foto).HasMaxLength(255).IsRequired();
            builder.HasOne(es => es.Genero).WithMany(c => c.Usuarios).HasForeignKey(fk => fk.GeneroId);
            builder.HasOne(es => es.TIpoUsuario).WithMany(c => c.Usuarios).HasForeignKey(fk => fk.TIpoUsuarioId);
        }
    }
}
