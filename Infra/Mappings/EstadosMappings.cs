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
    public class EstadosMapping : IEntityTypeConfiguration<Estados>
    {
        public void Configure(EntityTypeBuilder<Estados> builder)
        {
            builder.ToTable("Estados");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.NomeEstado).HasMaxLength(255).IsRequired();
            builder.Property(p => p.UF).HasMaxLength(2).IsRequired();
            builder.HasOne(p => p.Paises).WithMany(equals => e.Estados).HasForeignKey(fk => fk.PaisesId);
        }
    }
}
