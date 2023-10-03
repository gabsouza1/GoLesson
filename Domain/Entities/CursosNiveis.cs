using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CursosNiveis
    {
        public int NivelId { get; set; }
        public int CursoId { get; set; }
        public virtual NivelEscolaridade? NivelEscolaridade { get; set; }
        public virtual Curso? Curso { get; set; }
    }
}
