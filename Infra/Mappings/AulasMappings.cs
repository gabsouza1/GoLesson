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
            builder.HasKey(a => a.Id);
            builder.HasMany(a => a.Modulos).WithOne(m => m.Aulas).HasForeignKey(fk => fk.AulaId);
        }
    }
}
