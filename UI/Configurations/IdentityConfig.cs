﻿using Infra.Data;
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
            services.AddDbContext<DataContext>();
            services.AddDefaultIdentity<Usuario>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
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
