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
    public class ModuloApp : App<ModuloViewModel, Modulo>, IModuloApp
    {
        private readonly IModuloRepository _moduloRepository;

        public ModuloApp(IModuloRepository moduloRepository, IMapper mapper
            , ILogger<ModuloApp> logger) : base(moduloRepository, mapper, logger)
        {
        }
    }
}
