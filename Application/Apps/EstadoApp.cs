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
    public class EstadoApp : App<EstadoViewModel, Estado>, IEstadoApp
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoApp(IEstadoRepository estadoRepository, IMapper mapper
            , ILogger<EstadoApp> logger) : base(estadoRepository, mapper, logger)
        {
        }
    }
}
