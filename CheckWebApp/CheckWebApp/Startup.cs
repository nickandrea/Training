using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckWebApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CheckWebApp
{
    public class Startuppa
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeting, Greeting>();
            services.AddSingleton<IRestaurantData, InMemoryRestaurant>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreeting greeting, ILogger<Startuppa> logger, IConfiguration conf)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            /*app.Use(next =>
            {
               logger.LogInformation("Use Called");
                return async context =>
                {
                    logger.LogInformation("Request incoming" + DateTime.Now);
                    if (context.Request.Path.StartsWithSegments("/mym"))
                    {
                        await context.Response.WriteAsync("Hit!!");
                        logger.LogInformation("Request Handled");
                    }
                    else
                    {
                        await next(context);
                        logger.LogInformation("Response Incoming");
                    }
                };
            });
            */

            app.UseMvc(configureRoutes);

            app.UseWelcomePage(new WelcomePageOptions { Path="/wp"});

            app.Run(async (context) =>
            {
                String message = greeting.getGreting();
                message = conf["Greeting"];
                await context.Response.WriteAsync($"Not Found");
            });
        }

        private void configureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
