using Explan.Backend.Data.DataBase;

namespace Explan.Backend.Data.Inftastructure
{
	public interface IDbContextFactory
	{
		IUnitOfWork Create();

		AppDbContext CreateDbContext();
	}
}
