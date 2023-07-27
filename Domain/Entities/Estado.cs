using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Estado
    {
        public int Id { get; set; }
        public string NomeEstado { get; set; }
        public string UF { get; set; }
        public int PaisesId { get; set; }

        public virtual Pais? Paises { get; set; }

        public virtual ICollection<Cidade>? Cidades{ get; set; }

    }
}
