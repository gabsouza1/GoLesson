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
    public class CursosNiveisMapping : IEntityTypeConfiguration<CursosNiveis>
    {
        public void Configure(EntityTypeBuilder<CursosNiveis> builder)
        {
            builder.ToTable("CursosNiveis");
            builder.HasKey(cn => new { cn.NivelId, cn.CursoId });
        }
    }
}
