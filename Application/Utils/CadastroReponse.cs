using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utils
{
    public class CadastroReponse
    {
        public bool Sucesso { get; set; }
        public List<string> Erros { get; set; }


        public CadastroReponse() =>  Erros = new List<string>();

        public CadastroReponse(bool sucesso = true) : this() => Sucesso = sucesso;

        public void AdicionarErros(List<string> erros) =>
            Erros.AddRange(erros);
    }
}
