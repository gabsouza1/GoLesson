using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class NotaAvaliacao
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int AulaId { get; set; }
        public decimal Nota { get; set; }

        public virtual ApplicationUser? Usuarios { get; set; }
        public virtual Aula? Aulas { get; set; }
    }
}
