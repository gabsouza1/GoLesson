using Application.Apps;
using Application.Interfaces;
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
            services.AddScoped<DataContext>();

            //Applicações
            services.AddTransient<IArquivoApp, ArquivoApp>();
            services.AddTransient<IAulaApp, AulaApp>();
            services.AddTransient<IAvaliacaoCursoApp, AvaliacaoCursoApp>();
            services.AddTransient<ICategoriaApp, CategoriaApp>();
            services.AddTransient<ICidadeApp, CidadeApp>();
            services.AddTransient<ICodigoPostalApp, CodigoPostalApp>();
            services.AddTransient<ICompraApp, CompraApp>();
            services.AddTransient<ICursoApp, CursoApp>();
            services.AddTransient<IEnderecoApp, EnderecoApp>();
            services.AddTransient<IFavoritoApp, FavoritoApp>();
            services.AddTransient<IFormaPagamentoApp, FormaPagamentoApp>();
            services.AddTransient<IGeneroApp, GeneroApp>();
            services.AddTransient<IModuloApp, ModuloApp>();
            services.AddTransient<INotaAvaliacaoApp, NotaAvaliacaoApp>();
            services.AddTransient<IPaisApp, PaisApp>();
            services.AddTransient<IStatusPagamentoApp, StatusPagamentoApp>();
            services.AddTransient<IUsuarioCursoApp, UsuarioCursoApp>();
            services.AddTransient<IUsuarioModuloApp, UsuarioModuloApp>();


            //Repositorios
            services.AddTransient<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddTransient<IArquivoRepository, ArquivoRepository>();
            services.AddTransient<IAulaRepository, AulaRepository>();
            services.AddTransient<IAvaliacaoCursoRepository, AvaliacaoCursoRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<ICidadeRepository, CidadeRepository>();
            services.AddTransient<ICodigoPostalRepository, CodigoPostalRepository>();
            services.AddTransient<ICompraRepository, CompraRepository>();
            services.AddTransient<ICursoRepository, CursoRepository>();
            services.AddTransient<IEnderecoRepsitory, EnderecoRepository>();
            services.AddTransient<IFavoritoRepository, FavoritoRepository>();
            services.AddTransient<IFormaPagamentoRepository, FormaPagamentoRepository>();
            services.AddTransient<IGeneroRepository, GeneroRepository>();
            services.AddTransient<IModuloRepository, ModuloRepository>();
            services.AddTransient<INotaAvaliacaoRepository, NotaAvaliacaoRepository>();
            services.AddTransient<IPaisRepository, PaisRepository>();
            services.AddTransient<IStatusPagamentoRepository, StatusPagamentoRepository>();
            services.AddTransient<IUsuarioCursoRepository, UsuarioCursoRepository>();
            services.AddTransient<IUsuarioModuloRepository, UsuarioModuloRepository>();
            return services;
        }
    }
}
