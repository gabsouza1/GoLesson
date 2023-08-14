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
    public class UsuarioApp : App<UsuarioViewModel, Usuario>, IApplicationUserApp
    {
        private readonly IUsuarioRepository _applicationUserRepository;

        public UsuarioApp(IUsuarioRepository applicationUserRepository, IMapper mapper
            , ILogger<UsuarioApp> logger) : base(applicationUserRepository, mapper, logger)
        {
        }
    }
}
