using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using VirtualServersApp.Shared.Services;
using VirtualServersApp.Client.Repositories;

namespace VirtualServersApp.Client {
    public class Startup {
        public void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<MemoryCacheService>();
            services.AddScoped<IProductRepository, FakeProductRepository>();
            services.AddSingleton<IOrderRepository, FakeOrderRepository>();
            services.AddScoped<IProductTypeRepository, FakeProductTypeRepository>();
            services.AddSingleton<IServerRepository, FakeServerRepository>();
        }

        public void Configure(IComponentsApplicationBuilder app) {
            app.AddComponent<App>("app");
        }
    }
}
