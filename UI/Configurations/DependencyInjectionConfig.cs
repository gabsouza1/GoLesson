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
            services.AddSingleton<DataContext>();
            return services;
        }
    }
}
