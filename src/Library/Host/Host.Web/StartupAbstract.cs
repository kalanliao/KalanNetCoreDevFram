using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Kalan.Lib.Utils.Core.Helpers;
using HostOptions = Kalan.Lib.Host.Web.Options.HostOptions;

namespace Kalan.Lib.Host.Web
{
	public abstract class StartupAbstract
	{
		protected readonly HostOptions HostOptions;
		protected readonly IHostEnvironment Env;

		protected StartupAbstract(IHostEnvironment env)
		{
			Env = env;
			var cfgHelper = new ConfigurationHelper();
			//加载主机配置项
			HostOptions = cfgHelper.Get<HostOptions>("Host", env.EnvironmentName) ?? new HostOptions();
		}

		public virtual void ConfigureServices(IServiceCollection services)
		{
			services.AddWebHost(HostOptions, Env);
		}

		public virtual void Configure(IApplicationBuilder app)
		{
			app.UseWebHost(HostOptions, Env);

			app.UseShutdownHandler();
		}
	}
}
