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
    public class FavoritosMapping : IEntityTypeConfiguration<Favorito>
    {
        public void Configure(EntityTypeBuilder<Favorito> builder)
        {
            builder.ToTable("Favoritos");
            builder.HasKey(f => new { f.UsuarioId, f.CursoId });
            builder.HasOne(f => f.Usuarios).WithMany(u => u.Favoritos).HasForeignKey(f => f.UsuarioId);
            builder.HasOne(f => f.Cursos).WithMany(c => c.Favoritos).HasForeignKey(f => f.CursoId);
        }
    }

}
