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
    public class CodigoPostalApp : App<CodigoPostalViewModel, CodigoPostal>, ICodigoPostalApp
    {
        private readonly ICodigoPostalRepository _codigoPostalRepository;

        public CodigoPostalApp(ICodigoPostalRepository codigoPostalRepository, IMapper mapper
            , ILogger<CodigoPostalApp> logger) : base(codigoPostalRepository, mapper, logger)
        {
        }
    }
}
