using Microsoft.EntityFrameworkCore;

namespace Explan.Backend.Data.DataBase
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
		}
	}
}
