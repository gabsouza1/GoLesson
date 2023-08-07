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
    public class AvaliacaoCursoApp : App<AvaliacaoCursoViewModel, AvaliacaoCurso>, IAvaliacaoCursoApp
    {
        private readonly IAvaliacaoCursoRepository _avaliacaoCursoRepository;

        public AvaliacaoCursoApp(IAvaliacaoCursoRepository avaliacaoCursoRepository, IMapper mapper
            , ILogger<AvaliacaoCursoApp> logger) : base(avaliacaoCursoRepository, mapper, logger)
        {
        }
    }
}
