using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class NivelEscolaridade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<CursosNiveis> CursosNiveis { get; set; }
    }
}
