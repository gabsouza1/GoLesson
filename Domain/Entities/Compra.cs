using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Compra
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataCompra { get; set; }
        public int StatusPagamentoId { get; set; }
        public int FormaPagamentoId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public virtual ApplicationUser? Usuarios { get; set; }
        public virtual StatusPagamento? StatusPagamento { get; set; }
        public virtual FormaPagamento? FormaPagamento { get; set; }

    }
}
