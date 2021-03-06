using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Rema1000ApiProject.Context;
using Rema1000ApiProject.Models;
using Rema1000ApiProject.Services;

namespace Rema1000ApiProject
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
            services.AddDbContext<Rema1000Context>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IService<Category>, CategorySqlService>();
            services.AddScoped<ICategoryRead<Category>, CategorySqlService>();
            services.AddScoped<IService<Product>, ProductSqlService>();
            services.AddScoped<ICategoryRead<Product>, ProductSqlService>();
            services.AddScoped<IService<Supplier>, SupplierSqlService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Rema1000ApiProject", Version = "v1" });
                var filePath = Path.Combine(AppContext.BaseDirectory, "Rema1000ApiProject.xml");
                c.IncludeXmlComments(filePath, includeControllerXmlComments: true);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rema1000ApiProject v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
