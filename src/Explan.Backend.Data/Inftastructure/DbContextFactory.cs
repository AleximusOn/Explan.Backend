using Autofac;
using Explan.Backend.Data.DataBase;

namespace Explan.Backend.Data.Inftastructure
{
	public class DbContextFactory : IDbContextFactory
	{
		private readonly IComponentContext _componentContext;

		public DbContextFactory(IComponentContext componentContext)
		{
			_componentContext = componentContext;
		}

		public IUnitOfWork Create()
		{
			return _componentContext.Resolve<IUnitOfWork>();
		}

		public AppDbContext CreateDbContext()
		{
			return _componentContext.Resolve<AppDbContext>();
		}
	}
}
