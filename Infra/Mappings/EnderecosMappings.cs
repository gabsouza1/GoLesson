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
    public class EnderecosMapping : IEntityTypeConfiguration<Enderecos>
    {
        public void Configure(EntityTypeBuilder<Enderecos> builder)
        {
            builder.ToTable("Enderecos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Numero).HasMaxLength(255).IsRequired();
            builder.HasOne(es => es.CodigoPostal).WithMany(c => c.Enderecos).HasForeignKey(fk => fk.CodigoPostalId);

        }
    }
}
