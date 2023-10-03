using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MateriaCursos
    {
        public int CursoId { get; set; }
        public int MateriaId { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual Materia Materia { get; set; }
    }
}
