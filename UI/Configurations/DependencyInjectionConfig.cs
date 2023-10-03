using Application.Apps;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Infra.Data;
using Infra.Repositories;

namespace UI.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services) 
        {
            //DbContext
            services.AddScoped<DataContext>();
            //Applicações
            services.AddScoped<IAvaliacaoCursoApp, AvaliacaoCursoApp>();
            services.AddScoped<ICategoriaApp, CategoriaApp>();
            services.AddScoped<ICompraApp, CompraApp>();
            services.AddScoped<ICursoApp, CursoApp>();
            services.AddScoped<ICursosNiveisApp, CursosNiveisApp>();
            services.AddScoped<IEnderecoApp, EnderecoApp>();
            services.AddScoped<IGeneroApp, GeneroApp>();
            services.AddScoped<IMateriaApp, MateriaApp>();
            services.AddScoped<IMateriaCursosApp, MateriaCursosApp>();
            services.AddScoped<INivelEscolaridadeApp, NivelEscolaridadeApp>();
            services.AddScoped<IUsuarioApp, UsuarioApp>();
            services.AddScoped<IUsuarioCursoApp, UsuarioCursoApp>();
            


            //Repositorios
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IAvaliacaoCursoRepository, AvaliacaoCursoRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ICompraRepository, CompraRepository>();
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<ICursosNiveisRepository, CursosNiveisRepository>();
            services.AddScoped<IEnderecoRepsitory, EnderecoRepository>();
            services.AddScoped<IGeneroRepository, GeneroRepository>();
            services.AddScoped<IMateriaRepository, MateriaRepository>();
            services.AddScoped<IMateriaCursosRepository, MateriaCursosRepository>();
            services.AddScoped<INivelEscolaridadeRepository, NivelEscolaridadeRepository>();
            services.AddScoped<IUsuarioCursoRepository, UsuarioCursoRepository>();
            return services;
        }
    }
}
