using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsuariosModulos
    {
        public int UsuarioId { get; set; }
        public int ModuloId { get; set; }
        public decimal NotaMedia { get; set; }

        public virtual ApplicationUser? Usuario { get; set; }
        public virtual Modulos? Modulos { get; set; }
    }
}
