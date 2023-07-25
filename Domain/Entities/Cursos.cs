using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cursos
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public decimal Valor { get; set; }


        public virtual ICollection<UsuariosCursos>? UsuariosCursos { get; set; }
        public virtual ICollection<Modulos>? Modulos { get; set; }
    }
}
