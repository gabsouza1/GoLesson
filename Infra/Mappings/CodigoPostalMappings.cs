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
            builder.HasKey(p => p.Id);
            builder.Property(p => p.codigo).HasMaxLength(10).IsRequired();
            builder.Property(p => p.bairro).HasMaxLength(255).IsRequired();
        }
    }
}
