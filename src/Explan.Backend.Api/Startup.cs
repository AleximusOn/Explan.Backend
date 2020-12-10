using Autofac;
using Autofac.Extensions.DependencyInjection;
using Explan.Backend.Api.Di;
using Explan.Backend.Data.DataBase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Explan.Backend.Api
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public ILifetimeScope AutofacContainer { get; private set; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<AppDbContext>(o =>
				o.UseInMemoryDatabase(Configuration.GetConnectionString("default")));

			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Explan.Backend.Api", Version = "v1" });
			});
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			AutofacContainer = app.ApplicationServices.GetAutofacRoot();
			
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Explan.Backend.Api v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}

		public void ConfigureContainer(ContainerBuilder builder)
		{
			builder.RegisterModule(new ApiModule());
		}
	}
}
