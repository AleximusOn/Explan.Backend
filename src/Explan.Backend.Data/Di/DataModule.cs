using Autofac;
using Explan.Backend.Data.Inftastructure;

namespace Explan.Backend.Data.Di
{
	public class DataModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
			builder.RegisterType<DbContextFactory>().As<IDbContextFactory>();
		}
	}
}
