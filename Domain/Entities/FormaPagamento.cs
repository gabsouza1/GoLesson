using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string NomeFormaPagamento { get; set; } 

        public virtual ICollection<Compra>? Compras { get; set; }
    }
}
