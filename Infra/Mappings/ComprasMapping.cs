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
    public class CompraMapping : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.ToTable("Compras");
            builder.HasKey(c => c.Id);
            builder.HasOne(c => c.Usuarios).WithMany(u => u.Compras).HasForeignKey(c => c.UsuarioId);
            builder.HasOne(c => c.Curso).WithMany(c => c.Compras).HasForeignKey(c => c.CursoId);
        }
    }

}
