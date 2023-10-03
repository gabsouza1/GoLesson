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
    public class NivelEscolaridadeApp : App<NivelEscolaridadeViewModel, NivelEscolaridade>, INivelEscolaridadeApp
    {
        private readonly INivelEscolaridadeRepository _nivelEscolaridadeRepository;

        public NivelEscolaridadeApp(INivelEscolaridadeRepository nivelEscolaridadeRepository, IMapper mapper
            , ILogger<NivelEscolaridadeApp> logger) : base(nivelEscolaridadeRepository, mapper, logger)
        {
        }
    }
}
