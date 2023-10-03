using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Apps
{
    public class MateriaCursosApp : App<MateriaCursosViewModel, MateriaCursos>, IMateriaCursosApp
    {
        private readonly IMateriaCursosRepository _materiaCursosRepository;

        public MateriaCursosApp(IMateriaCursosRepository _materiaCursosRepository, IMapper mapper
            , ILogger<MateriaCursosApp> logger) : base(_materiaCursosRepository, mapper, logger)
        {
        }
    }
}
