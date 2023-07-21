using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Estados
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string UF { get; set; }

        public virtual Paises Paises { get; set; }

        public virtual ICollection<Cidades>Cidades{ get; set; }

    }
}
