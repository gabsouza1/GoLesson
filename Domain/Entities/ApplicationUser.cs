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
        public virtual Generos? Generos { get; set; }
        public virtual ICollection<UsuariosCursos>? UsuariosCursos { get; set; }
        public virtual ICollection<Favoritos>? Favoritos { get; set; }
        public virtual ICollection<AvaliacoesCursos>? Avaliacoes { get; set;}
        public virtual ICollection<Enderecos>? Enderecos { get; set; }
        public virtual ICollection<NotasAvaliacoes>? NotasAvaliacoes { get; set; }
    }
}
