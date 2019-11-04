using Kalan.Lib.Utils.Core.Helpers;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Kalan.Lib.Logging.Serilog.GenericHost
{
	public static class GenericHostBuilderExtensions
	{
		public static IHostBuilder UseLogging(this IHostBuilder builder)
		{
			builder.UseSerilog((hostingContext, loggerConfiguration) =>
			{
				var cfgHelper = new ConfigurationHelper();
				var cfg = cfgHelper.Load("logging", hostingContext.HostingEnvironment.EnvironmentName);

				if (cfg != null)
				{
					loggerConfiguration
						.ReadFrom.Configuration(cfg);
				}

				loggerConfiguration.Enrich.FromLogContext();
			});

			return builder;
		}
	}
}
