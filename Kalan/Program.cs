using Kalan.Lib.Host.Web;

namespace Kalan
{
	public class Program
	{
		public static void Main(string[] args)
		{
			new HostBuilder().Run<Startup>(args);
		}
	}
}
