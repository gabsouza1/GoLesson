using Domain.Entities;
using Domain.Interfaces;
using Infra.Data;
using Infra.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace UI.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services) 
        {
            //DbContext
            services.AddSingleton<DataContext>();



            //Repositorios
            services.AddSingleton<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddSingleton<IArquivoRepository, ArquivoRepository>();
            services.AddSingleton<IAulaRepository, AulaRepository>();
            services.AddSingleton<IAvaliacaoCursoRepository, AvaliacaoCursoRepository>();
            services.AddSingleton<ICategoriaRepository, CategoriaRepository>();
            services.AddSingleton<ICidadeRepository, CidadeRepository>();
            services.AddSingleton<ICodigoPostalRepository, CodigoPostalRepository>();
            services.AddSingleton<ICompraRepository, CompraRepository>();
            services.AddSingleton<ICursoRepository, CursoRepository>();
            services.AddSingleton<IEnderecoRepsitory, EnderecoRepository>();
            services.AddSingleton<IFavoritoRepository, FavoritoRepository>();
            services.AddSingleton<IFormaPagamentoRepository, FormaPagamentoRepository>();
            services.AddSingleton<IGeneroRepository, GeneroRepository>();
            services.AddSingleton<IModuloRepository, ModuloRepository>();
            services.AddSingleton<INotaAvaliacaoRepository, NotaAvaliacaoRepository>();
            services.AddSingleton<IPaisRepository, PaisRepository>();
            services.AddSingleton<IStatusPagamentoRepository, StatusPagamentoRepository>();
            services.AddSingleton<IUsuarioCursoRepository, UsuarioCursoRepository>();
            services.AddSingleton<IUsuarioModuloRepository, UsuarioModuloRepository>();
            return services;
        }
    }
}
