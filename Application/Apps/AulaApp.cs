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
    public class AulaApp : App<AulaViewModel, Aula>, IAulaApp
    {
        private readonly IAulaRepository _aulaRepository;

        public AulaApp(IAulaRepository aulaRepository, IMapper mapper
            , ILogger<AulaApp> logger) : base(aulaRepository, mapper, logger)
        {
        }
    }
}
