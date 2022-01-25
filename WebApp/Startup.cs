using Microsoft.AspNetCore.Builder;
using Plugins.DataStore.InMemory;
using UseCases;
using UseCases.DataStorePluginInterfaces;
using WebApp.Data;

namespace WebApp
{
    public class Startup
    {
       public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            // Dependecy Injection for In-Memory Data Store
            services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();

            // Dependency Injection for Use Cases and Repositories
            services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();

        }
    }
}
