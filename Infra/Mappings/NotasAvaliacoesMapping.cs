using Domain.Interfaces;
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
    public class NotasAvaliacoesMapping : IEntityTypeConfiguration<NotaAvaliacao>
    {
        public void Configure(EntityTypeBuilder<NotaAvaliacao> builder)
        {
            builder.ToTable("NotasAvaliacoes");
            builder.HasKey(na => na.Id);
            builder.HasOne(na => na.Usuarios).WithMany(u => u.NotasAvaliacoes).HasForeignKey(na => na.UsuarioId);
            builder.HasOne(na => na.Aulas).WithMany(a => a.NotasAvaliacoes).HasForeignKey(na => na.AulaId);
        }
    }

}
