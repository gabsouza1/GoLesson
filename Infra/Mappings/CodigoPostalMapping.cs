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
            builder.ToTable("CodigosPostais");
            builder.HasKey(cp => cp.Id);
            builder.Property(cp => cp.Codigo).HasMaxLength(10).IsRequired();
            builder.HasMany(cp => cp.Enderecos).WithOne(e => e.CodigoPostal).HasForeignKey(fk => fk.CodigoPostalId);
        }
    }
}
