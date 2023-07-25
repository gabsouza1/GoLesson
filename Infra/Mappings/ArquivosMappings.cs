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
    public class ArquivosMapping : IEntityTypeConfiguration<Arquivos>
    {
        public void Configure(EntityTypeBuilder<Arquivos> builder)
        {
            builder.ToTable("Arquivos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(255).IsRequired();
            builder.Property(p => p.MIME).HasMaxLength(50).IsRequired();
            builder.HasOne(c => c.Cursos).WithMany(c => c.Arquivos).HasForeignKey(fk => fk.CursosId);
        }
    }
}
