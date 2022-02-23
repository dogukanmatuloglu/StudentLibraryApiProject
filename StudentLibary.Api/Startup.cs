using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentLibrary.Core.Repositories;

using StudentLibrary.Core.UnitOfWork;
using StudentLibrary.Data.Contexts;
using StudentLibrary.Data.Repositories;
using StudentLibrary.Data.UnitOfWork;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLibary.Api
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
           
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
