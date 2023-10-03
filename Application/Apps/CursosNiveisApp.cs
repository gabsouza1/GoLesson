using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Apps
{
    public class CursosNiveisApp : App<CursosNiveisViewModel, CursosNiveis>, ICursosNiveisApp
    {
        private readonly ICursosNiveisRepository _cursosNiveisRepository;

        public CursosNiveisApp(ICursosNiveisRepository cursosNiveisRepository, IMapper mapper
            , ILogger<CursosNiveisApp> logger) : base(cursosNiveisRepository, mapper, logger)
        {
        }
    }
}
