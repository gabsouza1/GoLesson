using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Generos
    {
        public int Id { get; set; }
        public string NomeGenero { get; set; }

        public virtual ICollection<ApplicationUser> User { get; set; }
    }
}
