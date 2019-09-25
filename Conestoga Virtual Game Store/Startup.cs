using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Conestoga_Virtual_Game_Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.AspNet.OData.Builder;
using Conestoga_Virtual_Game_Store.Models;
using Microsoft.AspNet.OData.Extensions;

namespace Conestoga_Virtual_Game_Store
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("GameStoreDB")));


            services.AddOData();
        }

        //Configure OData Service. Gets Called by Mvc routes
        public IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Game>("Games");
            builder.EntitySet<Member>("Members");
            return builder.GetEdmModel();
        }

        // Configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            #region DoNotTouch
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            #endregion

            app.UseMvc(routes =>
            {
                routes.Select().Expand().Filter().OrderBy().MaxTop(64).Count();
                routes.MapODataServiceRoute("odata", "odata", GetEdmModel());
                routes.MapRoute(
                    "main", "/{*data}",
                    defaults: new { controller = "Home", action = "index" });
                 
            });
        }
    }
}
