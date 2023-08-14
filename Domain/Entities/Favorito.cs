using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Favorito
    {
        public int UsuarioId { get; set; }
        public int CursoId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public virtual Usuario? Usuarios { get; set; }
        public virtual Curso? Cursos { get; set; }
    }
}
