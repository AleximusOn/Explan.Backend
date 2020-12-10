using System.IO;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace Explan.Backend.Api
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		private static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.UseServiceProviderFactory(new AutofacServiceProviderFactory())
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder
						.UseContentRoot(Directory.GetCurrentDirectory())
						.UseStartup<Startup>();
				})
				.ConfigureLogging(logging =>
				{
					logging.ClearProviders();
					logging.SetMinimumLevel(LogLevel.Debug);
				})
				.UseNLog();
	}
}
