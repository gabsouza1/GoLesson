using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [NotMapped]
        public virtual ICollection<MateriaCursos>? MateriaCursos { get; set; }
    }
}
