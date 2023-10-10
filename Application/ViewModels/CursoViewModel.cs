using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class CursoViewModel
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public string Descricao { get; set; }
        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }
        public decimal? Valor { get; set; }
        public bool Acessibilidade { get; set; }
        public string Capa { get; set; }
        public string? Criador { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        [NotMapped]
        public virtual ICollection<MateriaCursosViewModel>? Materias { get; set; }
        [NotMapped]
        public virtual CategoriaViewModel? Categoria { get; set; }
        [NotMapped]
        public virtual ICollection<UsuarioCursoViewModel>? UsuarioCurso {get;  set;}

    }
}
