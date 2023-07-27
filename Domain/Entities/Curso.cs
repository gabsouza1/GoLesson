using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Curso
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public virtual Categoria? Categorias { get; set; }
        public virtual ICollection<UsuarioCurso>? UsuariosCursos { get; set; }
        public virtual ICollection<Modulo>? Modulos { get; set; }
        public virtual ICollection<Aula>? Aulas { get; set; }
        public virtual ICollection<Favorito>? Favoritos { get; set; }
        public virtual ICollection<AvaliacaoCurso>? AvaliacaoCursos { get; set; }
    }
}
