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
    public class GeneroApp : App<GeneroViewModel, Genero>, IGeneroApp
    {
        private readonly IGeneroRepository _generoRepository;

        public GeneroApp(IGeneroRepository generoRepository, IMapper mapper
            , ILogger<GeneroApp> logger) : base(generoRepository, mapper, logger)
        {
        }
    }
}
