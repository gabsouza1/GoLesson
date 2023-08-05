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

        public CursoApp(ICursoRepository cursoRepository, IMapper mapper
            , ILogger<CursoApp> logger) : base(cursoRepository, mapper, logger)
        {
        }
    }
}
