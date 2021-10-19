using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.Web.Routing;
using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using React.AspNet;
using Training.B.Requests;
using Training.B.Services;

namespace Training.B.Web
{
    public class Startup
    {
        private readonly IWebHostEnvironment _webHostingEnvironment;

        public Startup(IWebHostEnvironment webHostingEnvironment)
        {
            _webHostingEnvironment = webHostingEnvironment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            if (_webHostingEnvironment.IsDevelopment())
            {
                //Add development configuration
            }

            services.AddTrainingBRequests();
            services.AddTrainingBServices();

            //React.net
            services.AddJsEngineSwitcher(options => options.DefaultEngineName = ChakraCoreJsEngine.EngineName)
                .AddChakraCore();
            services.AddReact();

            services.AddMvc();
            services.AddCms()
                .AddCmsAspNetIdentity<ApplicationUser>();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/util/Login";
            });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseReact(config =>
            {
                config
                    .SetReuseJavaScriptEngines(true)
                    .SetLoadBabel(false)
                    .SetLoadReact(false)
                    .AddScriptWithoutTransform("~/scripts/client.bundle.js");

                config.JsonSerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                config.JsonSerializerSettings.DefaultValueHandling = DefaultValueHandling.Ignore;
            });

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapContent();
            });
        }
    }
}
