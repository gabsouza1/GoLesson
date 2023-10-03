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
    public class MateriaMapping : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.ToTable("Materia");
            builder.HasKey(p => p.Id);
            builder.HasMany(m => m.MateriaCursos).WithOne(mc => mc.Materia).HasForeignKey(mc => mc.MateriaId);
        }
    }
}
