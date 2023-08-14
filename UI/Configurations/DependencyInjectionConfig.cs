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
            services.AddScoped<IArquivoApp, ArquivoApp>();
            services.AddScoped<IAulaApp, AulaApp>();
            services.AddScoped<IAvaliacaoCursoApp, AvaliacaoCursoApp>();
            services.AddScoped<ICategoriaApp, CategoriaApp>();
            services.AddScoped<ICidadeApp, CidadeApp>();
            services.AddScoped<ICodigoPostalApp, CodigoPostalApp>();
            services.AddScoped<ICompraApp, CompraApp>();
            services.AddScoped<ICursoApp, CursoApp>();
            services.AddScoped<IEnderecoApp, EnderecoApp>();
            services.AddScoped<IFavoritoApp, FavoritoApp>();
            services.AddScoped<IFormaPagamentoApp, FormaPagamentoApp>();
            services.AddScoped<IGeneroApp, GeneroApp>();
            services.AddScoped<IModuloApp, ModuloApp>();
            services.AddScoped<INotaAvaliacaoApp, NotaAvaliacaoApp>();
            services.AddScoped<IPaisApp, PaisApp>();
            services.AddScoped<IStatusPagamentoApp, StatusPagamentoApp>();
            services.AddScoped<IUsuarioCursoApp, UsuarioCursoApp>();
            services.AddScoped<IUsuarioModuloApp, UsuarioModuloApp>();


            //Repositorios
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IArquivoRepository, ArquivoRepository>();
            services.AddScoped<IAulaRepository, AulaRepository>();
            services.AddScoped<IAvaliacaoCursoRepository, AvaliacaoCursoRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<ICodigoPostalRepository, CodigoPostalRepository>();
            services.AddScoped<ICompraRepository, CompraRepository>();
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<IEnderecoRepsitory, EnderecoRepository>();
            services.AddScoped<IFavoritoRepository, FavoritoRepository>();
            services.AddScoped<IFormaPagamentoRepository, FormaPagamentoRepository>();
            services.AddScoped<IGeneroRepository, GeneroRepository>();
            services.AddScoped<IModuloRepository, ModuloRepository>();
            services.AddScoped<INotaAvaliacaoRepository, NotaAvaliacaoRepository>();
            services.AddScoped<IPaisRepository, PaisRepository>();
            services.AddScoped<IStatusPagamentoRepository, StatusPagamentoRepository>();
            services.AddScoped<IUsuarioCursoRepository, UsuarioCursoRepository>();
            services.AddScoped<IUsuarioModuloRepository, UsuarioModuloRepository>();
            return services;
        }
    }
}
