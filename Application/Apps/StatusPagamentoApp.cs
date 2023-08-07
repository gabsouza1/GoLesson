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
    public class StatusPagamentoApp : App<StatusPagamentoViewModel, StatusPagamento>, IStatusPagamentoApp
    {
        private readonly IStatusPagamentoRepository _statusPagamentoRepository;

        public StatusPagamentoApp(IStatusPagamentoRepository statusPagamentoRepository, IMapper mapper
            , ILogger<StatusPagamentoApp> logger) : base(statusPagamentoRepository, mapper, logger)
        {
        }
    }
}
