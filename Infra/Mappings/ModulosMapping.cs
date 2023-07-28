
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
    public class ModulosMapping : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            builder.ToTable("Modulos");
            builder.HasKey(m => m.Id);
            builder.HasOne(m => m.Cursos).WithMany(c => c.Modulos).HasForeignKey(m => m.CursoId);
            builder.HasMany(m => m.UsuariosModulos).WithOne(um => um.Modulos).HasForeignKey(um => um.ModuloId);
        }
    }
}
