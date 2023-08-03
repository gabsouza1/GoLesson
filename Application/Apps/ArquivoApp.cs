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
    public class ArquivoApp : App<ArquivoViewModel, Arquivo>, IArquivoApp
    {
        private readonly IArquivoRepository _arquivoRepository;

        public ArquivoApp(IArquivoRepository arquivoRepository, IMapper mapper
            , ILogger<ArquivoApp> logger) : base(arquivoRepository, mapper, logger)
        {
        }
    }
}
