
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
    public class ModulosMapping : IEntityTypeConfiguration<Modulos>
    {
        public void Configure(EntityTypeBuilder<Modulos> builder)
        {
            builder.ToTable("Modulos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Titulo).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(255).IsRequired();
        }
    }
}
