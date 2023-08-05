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
    public class CidadeApp : App<CidadeViewModel, Cidade>, ICidadeApp
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeApp(ICidadeRepository cidadeRepository, IMapper mapper
            , ILogger<CidadeApp> logger) : base(cidadeRepository, mapper, logger)
        {
        }
    }
}
