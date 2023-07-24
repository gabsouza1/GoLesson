using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CodigoPostal
    {
        public int Id { get; set; }
        public string Codigo{ get; set; }
        public string Bairro { get; set; }
        public int CidadeId { get; set; }

        public virtual Cidades? Cidades { get; set; }

        public virtual ICollection<Enderecos>? Enderecos { get; set; }

    }
}
