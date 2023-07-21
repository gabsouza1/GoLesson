using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CodigoPostal
    {
        public int Id { get; set; }
        public string codigo{ get; set; }
        public string bairro { get; set; }


        public virtual Cidades Cidades { get; set; }

        public virtual ICollection<Endercos>Enderecos { get; set; }

    }
}
