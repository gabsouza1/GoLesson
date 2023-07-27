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
    public class AulasMapping : IEntityTypeConfiguration<Aula>
    {
        public void Configure(EntityTypeBuilder<Aula> builder)
        {
            builder.ToTable("Aulas");
            builder.HasKey(a => a.Id);
            builder.HasOne(a => a.Modulos).WithMany(m => m.Aulas).HasForeignKey(a => a.ModuloId);
            builder.HasOne(a => a.Cursos).WithMany(c => c.Aulas).HasForeignKey(a => a.CursoId);
        }
    }
}
