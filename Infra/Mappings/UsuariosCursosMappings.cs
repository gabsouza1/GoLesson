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
    public class UsuariosCursosMapping : IEntityTypeConfiguration<UsuariosCursos>
    {
        public void Configure(EntityTypeBuilder<UsuariosCursos> builder)
        {
            builder.ToTable("UsuariosCursos");
            builder.HasKey(p => new { p.UsuarioId, p.CursoId });
        }
    }
}