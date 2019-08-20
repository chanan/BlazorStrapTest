using BlazorStrap;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorStrapTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBootstrapCSS();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
