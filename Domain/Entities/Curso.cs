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
        public string Capa { get; set; }
        public decimal Valor { get; set; }
        public bool Acessibilidade { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedAt { get; set; } = DateTime.Now;
        public virtual Categoria? Categorias { get; set; }
        public virtual ICollection<UsuarioCurso>? UsuariosCursos { get; set; }
        public virtual ICollection<AvaliacaoCurso>? AvaliacaoCursos { get; set; }
        public virtual ICollection<MateriaCursos>? MateriasCursos { get; set; }
        public virtual ICollection<CursosNiveis>? CursosNiveis { get; set; }
        public virtual ICollection<Compra>? Compras { get; set; }
    }
}
