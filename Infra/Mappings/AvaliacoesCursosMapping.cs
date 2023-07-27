using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    public class AvaliacoesCursosMapping : IEntityTypeConfiguration<AvaliacaoCurso>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoCurso> builder)
        {
            builder.ToTable("AvaliacoesCursos");
            builder.HasKey(ac => ac.Id);
            builder.HasOne(ac => ac.Usuarios).WithMany(u => u.AvaliacoesCursos).HasForeignKey(ac => ac.UsuarioId);
            builder.HasOne(ac => ac.Cursos).WithMany(c => c.AvaliacaoCursos).HasForeignKey(ac => ac.CursoId);
        }
    }
}
