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
        
        public virtual Generos Generos { get; set; }

        public virtual ICollection<UsuariosCursos> UsuariosCursos { get; set; }
    }
}
