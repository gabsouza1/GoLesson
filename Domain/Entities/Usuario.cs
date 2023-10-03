using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario : IdentityUser<int>
    {
        public string? NomeCompleto { get; set; }
        public DateTime? DataNasc {  get; set; }
        public string? Foto { get; set; }
        public int? GeneroId { get; set; }
        public bool Ativo { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? LastUpdatedAt { get; set; } = DateTime.Now;
        public virtual Genero? Generos { get; set; }
        public virtual ICollection<UsuarioCurso>? UsuariosCursos { get; set; }
        public virtual ICollection<AvaliacaoCurso>? AvaliacoesCursos { get; set;}
        public virtual ICollection<Endereco>? Enderecos { get; set; }
        public virtual ICollection<Compra>? Compras { get; set; }
    }
}
