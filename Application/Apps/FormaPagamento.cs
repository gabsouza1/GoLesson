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
    public class FormaPagamentoApp : App<FormaPagamentoViewModel, FormaPagamento>, IFormaPagamentoApp
    {
        private readonly IFormaPagamentoRepository _formapagamentoRepository;

        public FormaPagamentoApp(IFormaPagamentoRepository formapagamentoRepository, IMapper mapper
            , ILogger<FormaPagamentoApp> logger) : base(formapagamentoRepository, mapper, logger)
        {
        }
    }
}
