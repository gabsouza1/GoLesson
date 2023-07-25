using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Enderecos
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string numero { get; set; }
        public int CodigoPostalId { get; set; }
        public int UsuarioId { get; set; }

        public virtual CodigoPostal? CodigoPostal { get; set; }
        public virtual Usuarios? Usuarios { get; set; }

    }
}
