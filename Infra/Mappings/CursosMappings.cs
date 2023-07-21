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
    public class CursosMapping : IEntityTypeConfiguration<Cursos>
    {
        public void Configure(EntityTypeBuilder<Cursos> builder)
        {
            builder.ToTable("Cursos");
            builder.HasKey(p => p.Id);
        }
    }
}
