using Infra.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace UI.Configurations
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            string conn = "server=localhost;port=3306;database=golesson;user=root;password=admin;Connect Timeout=300";
            services.AddDbContext<DataContext>(options =>
                options.UseMySql(conn, ServerVersion.AutoDetect(conn))
            ); ;
            services.AddDefaultIdentity<Usuario>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            return services;
        }
    }
}
