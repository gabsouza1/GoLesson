using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsuarioCurso
    {
        public int UsuarioId { get; set; }
        public int CursoId { get; set; }

        public virtual Usuario? User { get; set; }
        public virtual Curso? Cursos { get; set; }
    }
}
