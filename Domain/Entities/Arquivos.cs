using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Arquivos
    {
        public int Id { get; set; }
        public string NomeArquivo { get; set; }
        public string MIME { get; set; }
        public int AulaId { get; set; }

        public virtual Aulas? Aulas { get; set; }
    }
}
