using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
	public class ValueContext : DbContext
	{
		public ValueContext(DbContextOptions<ValueContext> options) : base(options) {}

		public DbSet<Value> Values { get; set; }
	}
}
