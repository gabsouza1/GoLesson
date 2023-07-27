using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Aula
    {
        public int Id { get; set; }
        public int ModuloId { get; set; }
        public int CursoId { get; set; }
        public string NomeAula { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public virtual Modulo? Modulos { get; set; }
        public virtual Curso? Cursos { get; set; }
        public virtual ICollection<Arquivo>? Arquivos { get; set; }
        public virtual ICollection<NotaAvaliacao>? NotasAvaliacoes { get; set; }
    }
}
