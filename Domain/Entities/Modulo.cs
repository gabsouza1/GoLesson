using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Modulo
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int AulaId { get; set; }
        public int CursoId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public virtual Curso? Cursos { get; set; }
        public virtual ICollection<Aula>? Aulas { get; set; }
        public virtual ICollection<UsuarioModulo>? UsuariosModulos { get; set; }
    }
}
