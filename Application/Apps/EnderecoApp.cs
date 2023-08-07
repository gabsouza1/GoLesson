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
    public class EnderecoApp : App<EnderecoViewModel, Endereco>, IEnderecoApp
    {
        private readonly IEnderecoRepsitory _enderecoRepository;

        public EnderecoApp(IEnderecoRepsitory enderecoRepository, IMapper mapper
            , ILogger<EnderecoApp> logger) : base(enderecoRepository, mapper, logger)
        {
        }
    }
}
