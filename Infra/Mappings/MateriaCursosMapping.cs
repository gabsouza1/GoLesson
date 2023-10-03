using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    public class MateriaCursosMapping : IEntityTypeConfiguration<MateriaCursos>
    {
        public void Configure(EntityTypeBuilder<MateriaCursos> builder)
        {
            builder.ToTable("MateriasCursos");
            builder.HasKey(p => new { p.MateriaId, p.CursoId});
        }
    }
}
