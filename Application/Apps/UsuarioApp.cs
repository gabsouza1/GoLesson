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
    public class UsuarioApp : App<UsuarioViewModel, Usuario>, IUsuarioApp
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioApp(IUsuarioRepository usuarioRepository, IMapper mapper
            , ILogger<UsuarioApp> logger) : base(usuarioRepository, mapper, logger)
        {
        }
    }
}
