using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {

        public int GeneroId { get; set; }
        public string? Foto { get; set; }
        public bool Ativo { get; set; }
        public DateTime? CreatedAt { get; set; } 
        public DateTime? LastUpdatedAt { get; set; } 
        public virtual Genero? Generos { get; set; }
        public virtual ICollection<UsuarioCurso>? UsuariosCursos { get; set; }
        public virtual ICollection<UsuarioModulo> UsuarioModulos { get; set; }
        public virtual ICollection<Favorito>? Favoritos { get; set; }
        public virtual ICollection<AvaliacaoCurso>? AvaliacoesCursos { get; set;}
        public virtual ICollection<Endereco>? Enderecos { get; set; }
        public virtual ICollection<NotaAvaliacao>? NotasAvaliacoes { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
    }
}
