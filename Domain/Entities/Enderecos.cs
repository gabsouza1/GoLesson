using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Enderecos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public int CodigoPostalId { get; set; }
        public int UsuarioId { get; set; }

        public virtual CodigoPostal? CodigoPostal { get; set; }
        public virtual ApplicationUser? Usuarios { get; set; }

    }
}
