using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGrapiApi.Configurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DataGrapiApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string DataGraphOrigin = "_mydatagraph";


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen(o =>
            {
                o.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "DataGraph API", Description = "API for DataGraph BI reporting application" });
            });
            services.AddCors(o =>
            {
                //o.AddDefaultPolicy(options => {
                //    options.WithOrigins("Https://api.datagraph.com");
                //});
                o.AddPolicy(DataGraphOrigin, b =>
                {
                    b.WithOrigins("https://localhost<port>").AllowAnyHeader().AllowAnyMethod();
                });

                //o.AddPolicy("Test", c => {
                //    c.WithOrigins("Https://*.dez.com").SetIsOriginAllowedToAllowWildcardSubdomains();
                //});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors(DataGraphOrigin);
            app.UseMvc();

            // Boilerplate code for swagger
            var swaggerSettings = new SwaggerOptions();
            Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerSettings);

            app.UseSwagger(o =>
            {
                o.RouteTemplate = swaggerSettings.JsonRoute;
            });

            app.UseSwaggerUI(o => { o.SwaggerEndpoint(swaggerSettings.UIEndpoint, swaggerSettings.ApiDescription); });

        }
    }
}
