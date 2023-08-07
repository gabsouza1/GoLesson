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
    public class NotaAvaliacaoApp : App<NotaAvaliacaoViewModel, NotaAvaliacao>, INotaAvaliacaoApp
    {
        private readonly INotaAvaliacaoRepository _notaAvaliacaoRepository;

        public NotaAvaliacaoApp(INotaAvaliacaoRepository notaAvaliacaoRepository, IMapper mapper
            , ILogger<NotaAvaliacaoApp> logger) : base(notaAvaliacaoRepository, mapper, logger)
        {
        }
    }
}
