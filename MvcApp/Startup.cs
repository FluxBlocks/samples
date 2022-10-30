using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using FluxBlocks.Plugin;

namespace MvcWebApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var bootstrapper = new Bootstrapper();
            bootstrapper.AddPlugins(services);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseRouting().UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "app",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
