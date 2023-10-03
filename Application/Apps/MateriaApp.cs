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
    public class MateriaApp : App<MateriaViewModel, Materia>, IMateriaApp
    {
        private readonly IMateriaCursosRepository _materiaCursosRepository;

        public MateriaApp(IMateriaRepository _materiaRepository, IMapper mapper
            , ILogger<MateriaApp> logger) : base(_materiaRepository, mapper, logger)
        {
        }
    }
}
