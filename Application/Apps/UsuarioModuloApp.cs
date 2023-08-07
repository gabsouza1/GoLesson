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
    public class UsuarioModuloApp : App<UsuarioModuloViewModel, UsuarioModulo>, IUsuarioModuloApp
    {
        private readonly IUsuarioModuloRepository _usuarioModuloRepository;

        public UsuarioModuloApp(IUsuarioModuloRepository usuarioModuloRepository, IMapper mapper
            , ILogger<UsuarioModuloApp> logger) : base(usuarioModuloRepository, mapper, logger)
        {
        }
    }
}
