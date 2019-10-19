using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FootballApplication.Models;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FootballApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddSession();

            services.AddMvc();

            services.AddDbContext<footballappContext>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "LeagueTeams",
                    "LeagueTeams/{id?}",
                    defaults: new { controller = "LeagueTeams", action = "Index" }
                );

                routes.MapRoute(
                    "Teams",
                    "Teams/{id}",
                    defaults: new { controller = "Teams", action = "Index" }
                );

                routes.MapRoute(
                    "default",
                    "{controller=Matches}/{action=Index}/{id?}"
                );
            });
        }
    }
}
