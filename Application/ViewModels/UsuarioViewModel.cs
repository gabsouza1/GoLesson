using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNasc { get; set; }
        public int Genero { get; set; }
        public string? Foto { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int Endereco { get; set; }
        public int CodigoPostal { get; set; }
        public int Estado { get; set; }
        public int Cidade { get; set; }
        public int Pais { get; set; }
    }
}
