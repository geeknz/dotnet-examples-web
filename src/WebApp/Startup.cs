using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using nz.geek.colin.examples.dotnet.data;

namespace nz.geek.colin.examples.dotnet
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ValueContext>(options => options.UseSqlite("Data Source=values.db"));
			services.AddMvcCore()
				.AddJsonFormatters();

		}

		public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory, ValueContext context)
		{
			loggerFactory.AddConsole(LogLevel.Debug);
			app.UseMvc();

			DbInitializer.Initialize(context);
		}
	}
}
