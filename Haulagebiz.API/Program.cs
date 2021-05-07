using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Haulagebiz.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureAppConfiguration((hostingContext, config) =>
				{
					var env = hostingContext.HostingEnvironment;

					// add custom app settings
					config
						.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
						// When app is published
						.AddJsonFile("ocelot.json", optional: true, reloadOnChange: true)
						// When running using dotnet run and development mode
						.AddJsonFile($"ocelot.{env.EnvironmentName}.json", optional: false, reloadOnChange: true);

					config.AddEnvironmentVariables();
				})
				.ConfigureLogging((hostingContext, logging) =>
				{

				})
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
