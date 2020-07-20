using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebGentle_BookStore
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my first middleware!");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my first middleware!");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my second middleware!");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my second middleware!");

            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my third middleware!");
            //    await next();
            //}); 
            
            

            app.UseRouting();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.Map("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/products", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Products!");
            //    });
            //});
        }
    }
}
