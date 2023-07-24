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
    public class CodigoPostalMapping : IEntityTypeConfiguration<CodigoPostal>
    {
        public void Configure(EntityTypeBuilder<CodigoPostal> builder)
        {
            builder.ToTable("CodigoPostal");
            builder.HasKey(cp => cp.Id);
            builder.Property(cp => cp.Codigo).HasMaxLength(10).IsRequired();
            builder.Property(p => p.Bairro).HasMaxLength(255).IsRequired();
            builder.HasOne(cp => cp.Cidades).WithMany(c => c.CodigoPostal).HasForeignKey(fk => fk.CidadeId);
            builder.HasMany(cp => cp.Enderecos).WithOne(e => e.CodigoPostal).HasForeignKey(fk => fk.CodigoPostalId);
        }
    }
}
