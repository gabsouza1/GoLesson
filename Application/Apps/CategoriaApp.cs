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
    public class CategoriaApp : App<CategoriaViewModel, Categoria>, ICategoriaApp
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaApp(ICategoriaRepository categoriaRepository, IMapper mapper
            , ILogger<CategoriaApp> logger) : base(categoriaRepository, mapper, logger)
        {
        }
    }
}
