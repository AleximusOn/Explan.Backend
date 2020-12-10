using Autofac;
using Explan.Backend.Common.Di;
using Explan.Backend.Core.Di;
using Explan.Backend.Data.Di;

namespace Explan.Backend.Api.Di
{
	public class ApiModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{


			RegisterAppModules(builder);

			base.Load(builder);
		}

		private void RegisterAppModules(ContainerBuilder builder)
		{
			builder.RegisterModule(new CommonModule());
			builder.RegisterModule(new CoreModule());
			builder.RegisterModule(new DataModule());
		}
	}
}
