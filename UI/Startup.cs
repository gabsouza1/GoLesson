using Application.Apps;
using Application.Interfaces;
using Domain.Entities;
using Infra.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UI.Configurations;
using UI.Data;
using UI.Extensions;

namespace UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapperConfiguration();
            services.AddControllersWithViews();
            services.AddIdentityConfiguration(Configuration);
            services.ResolveDependencies();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "registro",
                    pattern: "registro",
                    defaults: new { controller = "Registro", action = "Registrar" });

                endpoints.MapControllerRoute(
                    name: "login",
                    pattern: "login",
                    defaults: new { controller = "Login", action = "Login" });
                endpoints.MapControllerRoute(
                    name: "logout",
                    pattern: "logout",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}