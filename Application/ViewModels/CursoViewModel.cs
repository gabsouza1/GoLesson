using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class CursoViewModel
    {
        public int Id { get; set; }
        [DisplayName("Titulo")]
        public string NomeCurso { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }
        [DisplayName("Preço")]
        public decimal Valor { get; set; }
        [DisplayName("Acessibilidade")]
        public bool Acessibilidade { get; set; }
        [DisplayName("Nivel")]
        public int NivelId { get; set; }
        [DisplayName("Capa")]
        public string? Capa { get; set; }
        [DisplayName("Matérias")]
        public List<string>? Materias { get; set; }
        public int UsuarioId { get; set; }
        [DisplayName("Criado Por")]
        public string? Criador { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }

        public bool HasCurso { get; set; }

        [NotMapped]
        public virtual ICollection<MateriaCursosViewModel>? MateriasCursos { get; set; }
        public virtual CursosNiveisViewModel? CursosNiveis  { get; set; }
        [NotMapped]
        public virtual CategoriaViewModel? Categoria { get; set; }
        [NotMapped]
        public virtual ICollection<UsuarioCursoViewModel>? UsuarioCurso {get;  set;}

    }
}
