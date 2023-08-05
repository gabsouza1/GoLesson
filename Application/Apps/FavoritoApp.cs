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
    public class FavoritoApp : App<FavoritoViewModel, Favorito>, IFavoritoApp
    {
        private readonly IFavoritoRepository _favoritoRepository;

        public FavoritoApp(IFavoritoRepository favoritoRepository, IMapper mapper
            , ILogger<FavoritoApp> logger) : base(favoritoRepository, mapper, logger)
        {
        }
    }
}
