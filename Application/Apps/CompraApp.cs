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
	public class CompraApp : App<CompraViewModel, Compra>, ICompraApp
	{
		private readonly ICompraRepository _compraRepository;

		public CompraApp(ICompraRepository compraRepository, IMapper mapper
			, ILogger<CompraApp> logger) : base(compraRepository, mapper, logger)
		{
		}
	}
}
