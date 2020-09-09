using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentManagement.Web.Api.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AssignmentManagement.Web.Api
{
    public class Startup
    {

        #region Fields

        private readonly string _CORSLocalPolicy = "CORS_LOCAL_POLICY";

        #endregion

        #region Properties

        public IConfiguration Configuration { get; }

        #endregion

        #region Constructor

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        #region Methods
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(_CORSLocalPolicy, builder =>
                {
                    builder.WithOrigins(Configuration["LocalClient"])
                    .AllowAnyHeader()
                    .AllowAnyOrigin();
                });
            });

            services.AddHealthChecks();
            services.AddSwaggerDocument();
            services.ConfigureAssignmentManagementApiServices(Configuration);
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHealthChecks("/health");
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseCors(_CORSLocalPolicy);

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        #endregion
    }
}
