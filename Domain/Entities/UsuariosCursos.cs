using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsuariosCursos
    {
        public int UsuarioId { get; set; }
        public int CursoId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Cursos Cursos { get; set; }
    }
}
