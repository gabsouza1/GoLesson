using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Apps
{
    public class CursoApp : App<CursoViewModel, Curso>, ICursoApp
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IUsuarioCursoRepository _usuarioCursoRepository;
        public CursoApp(ICursoRepository cursoRepository, IMapper mapper
            , ILogger<CursoApp> logger, IUsuarioCursoRepository usuarioCursoRepository) : base(cursoRepository, mapper, logger)
        {
            _usuarioCursoRepository = usuarioCursoRepository;
        }

        public async Task<List<Curso?>> GetCursosByTeacher(int id)
        {
            var usuarioCursos = await _usuarioCursoRepository.GetAll();


            var cursoProfessor = usuarioCursos.Where(uc => uc.UsuarioId == id).Select(uc => uc.Cursos).ToList();

            return cursoProfessor;
        }
    }
}
