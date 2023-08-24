using Infra.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using UI.Extensions;
using Microsoft.Extensions.Options;

namespace UI.Configurations
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            string conn = "server=localhost;port=3306;database=golesson;user=root;password=admin;Connect Timeout=300";
            services.AddDbContext<DataContext>();
            services.AddDefaultIdentity<Usuario>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 1;
                //User Settings
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                //Sign In settings
                options.SignIn.RequireConfirmedAccount = true;

                //Lockout Settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);
                options.Lockout.MaxFailedAccessAttempts = 5;
            }
            )
                    .AddRoles<IdentityRole<int>>()
                    .AddEntityFrameworkStores<DataContext>()
                    .AddDefaultTokenProviders()
                    .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory>();
            return services;
        }
    }
}
