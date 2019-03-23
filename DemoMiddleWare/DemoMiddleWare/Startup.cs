using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DemoMiddleWare
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (ctx, next) =>
            {
                await ctx.Response.WriteAsync("Passou no Use 1 /");
                await next.Invoke();
            });

            app.Use(MeuMiddleWare());

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            app.Use(async (ctx, next) =>
            {
                await ctx.Response.WriteAsync("Passou no Use 3 /");
                //await next.Invoke();
            });
        }

        private static Func<HttpContext, Func<Task>, Task> MeuMiddleWare()
        {
            return async (ctx, next) =>
            {
                await ctx.Response.WriteAsync("Passou no Use 2 /");
                await next.Invoke();
            };
        }
    }
}
