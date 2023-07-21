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
    public class CidadesMapping : IEntityTypeConfiguration<Estados>
    {
        public void Configure(EntityTypeBuilder<Cidades> builder)
        {
            builder.ToTable("Cidades");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NomeCidade).HasMaxLength(255).IsRequired();
            
        }
    }
}
