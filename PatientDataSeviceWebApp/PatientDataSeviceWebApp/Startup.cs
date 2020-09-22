using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PatientDataSeviceWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc((opt) => { opt.EnableEndpointRouting = false; });//Register MVC Specific Services
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Routing Middlewre must be top most middleware in the pipeline
            app.UseRouting();
            //setup first middleware
            app.UseStaticFiles();//wwwroot
            //setup MVC Middleware
            app.UseMvc(ConfigureRoutes); 
        }

        static void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            // http://localhost:5000/a/b
            routeBuilder.MapRoute("default", "patients/{controller}/{action}");
            // http://localhost:5000/a/b/c
            routeBuilder.MapRoute("select", "patients/{controller}/{action}/{mrn}");
            // http://localhost:5000/a/b/c/d
            /* Dictionary -> RouteData
             *                  controller=a
             *                   action=b
             *                   mrn=c
             *                   name=d
             */                   
                                                                 
            routeBuilder.MapRoute("add", "patients/{controller}/{action}/{mrn}/{name}");

        }
    }
}
