using Application.ViewModels;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICursoApp : IApp<CursoViewModel, Curso>
    {
        Task<List<CursoViewModel>> GetCursosByTeacher(int id);
        Task<List<CursoViewModel>> GetCursosByStudent(int id);
        Task<Curso> AddCursoAsync(CursoViewModel curso);
        Task<Curso> BuyCourse(int cursoId, int usuarioId);
    }
}
