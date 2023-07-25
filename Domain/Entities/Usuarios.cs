using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string foto { get; set; }
        public int GeneroId { get; set; }
        public int TIpoUsuarioId { get; set; }
        

    }
}
