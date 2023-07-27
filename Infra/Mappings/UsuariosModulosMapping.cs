using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infra.Mappings
{
    public class UsuariosModulosMapping : IEntityTypeConfiguration<UsuarioModulo>
    {
        public void Configure(EntityTypeBuilder<UsuarioModulo> builder)
        {
            builder.HasKey(um => new { um.UsuarioId, um.ModuloId });
            builder.HasOne(um => um.Usuario).WithMany(u => u.UsuarioModulos).HasForeignKey(um => um.UsuarioId);
            builder.HasOne(um => um.Modulos).WithMany(m => m.UsuariosModulos).HasForeignKey(um => um.ModuloId);
            // Configurações adicionais para a entidade UsuariosModulos, se houver
        }
    }

}
