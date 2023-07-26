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
    public class AulasMapping : IEntityTypeConfiguration<Aulas>
    {
        public void Configure(EntityTypeBuilder<Aulas> builder)
        {
            builder.ToTable("Aulas");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NomeAula).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Conteudo).HasMaxLength(255).IsRequired();
            builder.HasMany(a => a.Modulos).WithOne(a => a.Aulas).HasForeignKey(x => x.AulaId);
        }
    }
}
