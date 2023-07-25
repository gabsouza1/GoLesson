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
    public class GenerosMapping : IEntityTypeConfiguration<Generos>
    {
        public void Configure(EntityTypeBuilder<Generos> builder)
        {
            builder.ToTable("Generos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(255).IsRequired();

        }
    }
}
