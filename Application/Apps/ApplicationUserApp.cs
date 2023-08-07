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
    public class ApplicationUserApp : App<UsuarioViewModel, ApplicationUser>, IApplicationUserApp
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public ApplicationUserApp(IApplicationUserRepository applicationUserRepository, IMapper mapper
            , ILogger<ApplicationUserApp> logger) : base(applicationUserRepository, mapper, logger)
        {
        }
    }
}
