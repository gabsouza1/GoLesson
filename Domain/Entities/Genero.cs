using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Genero
    {
        public int Id { get; set; }
        public string NomeGenero { get; set; }

        public virtual ICollection<Usuario>? Usuario { get; set; }
    }
}
