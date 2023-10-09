using Application.ViewModels;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUsuarioApp : IApp<UsuarioViewModel, Usuario>
    {
        Task<Usuario> AddStudentAsync(RegistroViewModel registro);
        Task<Usuario> AddTeacherAsync(RegistroViewModel registro);
        Task<Usuario> EditProfileAsync(UsuarioViewModel usuarioViewModel);
    }
}
