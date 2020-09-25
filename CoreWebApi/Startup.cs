using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CoreWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //register services - container
            services.AddSingleton<Repository.IUserDataRepository, Repository.UserDataRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //http://loclahost:8000/abc/xyz/pqrs
            //Segments Count : 3
            //Process incoming HttpRequest and extract segment values from Url
            //Select Route for incoming http request
            //Route ? -> Path -> Name,template->Pattern matching (based on segment count)
            // From the route template extract segment variables
            // Contruct datastructure RouteData (Dictinary)
            // Add segment variables as RouteData Keys 
            //Extract values from incoming http request url segments
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
