using System.ComponentModel.DataAnnotations.Schema;

namespace Application.ViewModels
{
    public class MateriaCursosViewModel
    {
        public int MateriaId { get; set; }
        public int CursoId { get; set; }
        [NotMapped]
        public virtual MateriaViewModel? Materia { get; set; }
        [NotMapped]
        public virtual CursoViewModel? Curso { get; set; }
    }
}
