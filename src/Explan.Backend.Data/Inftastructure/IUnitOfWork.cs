using Explan.Backend.Data.DataBase;
using System;
using System.Threading.Tasks;

namespace Explan.Backend.Data.Inftastructure
{
	public interface IUnitOfWork : IDisposable
	{
		AppDbContext DbContext { get; }

		Task Commit();
	}
}
