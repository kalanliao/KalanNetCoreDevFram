using Microsoft.Extensions.DependencyInjection;
using Kalan.Lib.Cache.Abstractions;

namespace Kalan.Lib.Cache.MemoryCache
{
    public class ServiceCollectionConfig : IServiceCollectionConfig
    {
        public IServiceCollection Config(IServiceCollection services, CacheOptions options)
        {
            services.AddMemoryCache();

            services.AddSingleton<ICacheHandler, MemoryCacheHandler>();

            return services;
        }
    }
}
