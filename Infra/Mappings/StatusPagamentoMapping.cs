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
    public class StatusPagamentoMapping : IEntityTypeConfiguration<StatusPagamento>
    {
        public void Configure(EntityTypeBuilder<StatusPagamento> builder)
        {
            builder.ToTable("StatusPagamentos");
            builder.HasKey(sp => sp.Id);

        }
    }
}
