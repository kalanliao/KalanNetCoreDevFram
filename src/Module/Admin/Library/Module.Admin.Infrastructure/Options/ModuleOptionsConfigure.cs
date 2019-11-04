using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Kalan.Lib.Utils.Core.Options;

namespace Kalan.Module.Admin.Infrastructure.Options
{
    public class ModuleOptionsConfigure : IModuleOptionsConfigure
    {
        public void ConfigOptions(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AdminOptions>(configuration);
        }
    }
}
