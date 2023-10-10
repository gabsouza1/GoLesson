using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class MateriaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [NotMapped]
        public virtual ICollection<MateriaCursosViewModel>? MateriaCursos { get; set; }
    }
}
