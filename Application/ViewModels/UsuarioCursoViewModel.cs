using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class UsuarioCursoViewModel
    {
        public int CursoId { get; set; }
        public int UsuarioId { get; set; }
        [NotMapped]
        public virtual CursoViewModel? Curso { get; set; }
        [NotMapped]
        public virtual UsuarioViewModel? Usuario { get; set; }
    }
}
