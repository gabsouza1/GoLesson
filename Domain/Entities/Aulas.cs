using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Aulas
    {
        public int Id { get; set; }
        public int ModuloId { get; set; }
        public string NomeAula { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }

        public virtual ICollection<Arquivos>? Arquivos { get; set; }
        public virtual ICollection<Modulos>? Modulos { get; set; }
    }
}
