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
        public DateTime DataNascimento { get; set; }
        public int? Genero { get; set; }
        public int? EnderecoId { get; set; }
        public int? PaisId { get; set; }
        public int? CidadeId { get; set; }
        public int? EstadoId { get; set; }
    }
}
