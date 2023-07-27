using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pais
    {
        public int Id { get; set; }
        public string NomePais { get; set; }

        public virtual ICollection<Estado>? Estados { get; set; }
    }
}
