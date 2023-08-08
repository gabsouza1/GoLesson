using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ArquivoViewModel
    {
        public int  Id { get; set; }
        public string NomeArquivo { get; set; }
        public string MIME { get; set; }
        public int AulaId { get; set; }

        [NotMapped]
        public virtual AulaViewModel Aula { get; set; }
    }
}
