using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lectrure54_middleware
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(
                  async (context,next) => {

                      var s = context.Request.Query["somedata"];
                      if (s.Equals("a"))
                      {
                          await context.Response.WriteAsync("AoA Pakistan...\n");
                      }
                      await next();
                      await context.Response.WriteAsync("AoA Pakistan 1st middleware...\n");

                  }
                );

            app.Use(
                  async (context, next) => {

                      await context.Response.WriteAsync("AoA Pakistan again...\n");
                      await next();
                      await context.Response.WriteAsync("AoA Pakistan again 2nd middleware...\n");

                  }
                );
            app.Run(async (context)=> {

                await context.Response.WriteAsync("I am in the last one...\n");

            });

        }
    }
}
