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
    public class PaisApp : App<PaisViewModel, Pais>, IPaisApp
    {
        private readonly IPaisRepository _paisRepository;

        public PaisApp(IPaisRepository paisRepository, IMapper mapper
            , ILogger<PaisApp> logger) : base(paisRepository, mapper, logger)
        {
        }
    }
}
