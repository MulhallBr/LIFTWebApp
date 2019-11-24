using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LIFTWebApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace LIFTWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration["Data:LIFTWebAppLifts:ConnectionString"]));
            services.AddTransient<ILiftRepository, EFLiftRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseStatusCodePages(); 
            app.UseStaticFiles(); 
            app.UseMvc(routes => {

                routes.MapRoute(
                    name: "pagination",
                    template: "Lifts/Page{page}",
                    defaults: new { Controller = "Lift", action = "List" }
                    );


                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );

                //routes.MapRoute(
                //    name: "LogExercises",
                //    template: "{controller=LiftsCURD}/{action=Index}/{id?}"
                //    );
            });

            SeedData.EnsurePopulated(app);

            //app.UseMvcWithDefaultRoute();

        }
    }
}
