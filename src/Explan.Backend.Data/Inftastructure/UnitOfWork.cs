using Explan.Backend.Data.DataBase;
using System;
using System.Threading.Tasks;

namespace Explan.Backend.Data.Inftastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private bool disposedValue;

		public UnitOfWork(AppDbContext dbContext)
		{
			DbContext = dbContext;
		}

		public AppDbContext DbContext { get; private set; }

		public Task Commit()
		{
			return DbContext.SaveChangesAsync();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !disposedValue)
			{
				DbContext.Dispose();
			}

			disposedValue = true;
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
