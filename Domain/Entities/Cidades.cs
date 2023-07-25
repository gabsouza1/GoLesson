using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }

        public virtual Estados? Estados { get; set; }

        public virtual ICollection<CodigoPostal>?CodigoPostal { get; set; }

    }
}
