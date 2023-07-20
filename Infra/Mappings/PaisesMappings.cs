
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
    public class PaisesMapping : IEntityTypeConfiguration<Paises>
    {
        public void Configure(EntityTypeBuilder<Paises> builder)
        {
            builder.ToTable("Paises");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NomePais).HasMaxLength(255).IsRequired();
        }
    }
}
