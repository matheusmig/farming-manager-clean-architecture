using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApi.DependencyInjection;
using WebApi.Middlewares;

namespace CleanArch
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        #region Called for ASPNETCORE_ENVIRONMENT=Development

        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            services.AddInMemoryPersistence();
//            services.AddSQLServerPersistence(Configuration);
            services.AddControllers().AddControllersAsServices();
//           services.AddFeatureFlags(Configuration);
            services.AddVersioning();
            services.AddSwagger();
            services.AddUseCases();
            services.AddPresentersV1();
//            services.AddPresentersV2();
        }

        public void ConfigureDevelopment(
            IApplicationBuilder app,
            IWebHostEnvironment env,
            IApiVersionDescriptionProvider provider)
        {
            app.UseDeveloperExceptionPage();
            app.UseMiddleware<CustomExceptionHandlerMiddleware>();

            app.UseHttpsRedirection();
            //app.UseHealthChecks("/health");
            //            app.UseMetricServer();
            //            app.UseMangaHttpMetrics();
            app.UseRouting();
            app.UseVersionedSwagger(provider);
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints
                    .MapControllers();
            });


        }

        #endregion

        #region Called for ASPNETCORE_ENVIRONMENT=Production

        public void ConfigureProductionServices(IServiceCollection services)
        {
            services.AddControllers().AddControllersAsServices();
 //           services.AddBusinessExceptionFilter();
 //           services.AddFeatureFlags(Configuration);
            services.AddVersioning();
            services.AddSwagger();
            services.AddUseCases();
              services.AddSQLServerPersistence(Configuration);
            services.AddPresentersV1();
 //           services.AddPresentersV2();
             services.AddHttpContextAccessor();
 //           services.AddGitHubAuthentication(Configuration);
        }

        public void ConfigureProduction(
            IApplicationBuilder app,
            IWebHostEnvironment env,
            IApiVersionDescriptionProvider provider)
        {
            app.UseMiddleware<CustomExceptionHandlerMiddleware>();

            app.UseHttpsRedirection();
            app.UseHealthChecks("/health");
            //            app.UseMetricServer();
            //            app.UseMangaHttpMetrics();
            app.UseRouting();
            app.UseVersionedSwagger(provider);
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();
            app.UseEndpoints(endpoints =>
            {
                endpoints
                    .MapControllers()
                    .RequireAuthorization();
            });


        }

        #endregion
    }
}
