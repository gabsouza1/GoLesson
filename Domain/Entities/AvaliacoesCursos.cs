using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AvaliacoesCursos
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CursoId { get; set; }
        public decimal NotaAvaliacao { get; set; }

        public virtual ApplicationUser? Usuarios { get; set; }
        public virtual Cursos? Cursos { get; set; }
    }
}
