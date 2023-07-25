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
    public class CursosMapping : IEntityTypeConfiguration<Cursos>
    {
        public void Configure(EntityTypeBuilder<Cursos> builder)
        {
            builder.ToTable("Cursos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NomeCursos).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(p => p.valor).HasMaxLength(255).IsRequired();
            builder.HasOne(cu => cu.Cadegoria).WithMany(c => c.Cursos).HasForeignKey(fk => fk.CategoriaId);

        }
    }
}
