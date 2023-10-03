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
    public class NivelEscolaridadeMapping : IEntityTypeConfiguration<NivelEscolaridade>
    {
        public void Configure(EntityTypeBuilder<NivelEscolaridade> builder)
        {
            builder.ToTable("NivelEscolaridade");
            builder.HasKey(c => c.Id);
            builder.HasMany(ne => ne.CursosNiveis).WithOne(cn => cn.NivelEscolaridade).HasForeignKey(cn => cn.NivelId);

        }
    }
}
