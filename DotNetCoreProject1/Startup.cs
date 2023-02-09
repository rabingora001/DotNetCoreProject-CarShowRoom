using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DotNetCoreProject1.Services;
using DotNetCoreProject1.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreProject1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //*this is dependency injection
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyDbContext>(options => options.UseSqlite("Datasource = CarDatabase.db"));

            //Can be added two databases but not little consion.
            //services.AddDbContext<UserContext>(options => options.UseSqlite("Datasource = RegisteredUsers.db"));

            services.AddSingleton<ICarData, CarData>();
            services.AddMvc(x => x.EnableEndpointRouting = false);
            services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline. *This is middle ware.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MyDbContext myDatabase)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            //myDatabase.Database.EnsureDeleted();
            myDatabase.Database.EnsureCreated();

            app.UseDefaultFiles(); //default files are from index.html in wwwroot folder. this will be loaded first.

            //static files are from wwwroot folder. css and js
            app.UseStaticFiles();

            //routes-conventional. it matches "controller/action/?id"
            app.UseMvc(routes =>
            {
                //default route
                routes.MapRoute("default", "{controller=LoginAndRegister}/{action=Login}/{id?}");

                //dashboard route
                routes.MapRoute(
                    name: "Dashboard",
                    template: "{controller}/{action}/{name?}",
                    constraints: new { name = "[A-Za-z ]+" },
                    defaults: new { controller = "Dashboard", action = "DisplayDashboard", name = "Rabin Gora" });
                
            });

            
            app.UseMvc(routes =>
            {
                //login route. I'm using alternate routing for this.
                routes.MapRoute("Login", "{controller=LoginAndRegister}/{action=LoginAction}");

            });

            app.Run(async (context) =>
            {
                //no routes found. put at the end.
                await context.Response.WriteAsync("Page not found. Please, type the url correctly.");
            });
        }
    }
}
