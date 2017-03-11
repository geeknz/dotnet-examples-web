using Microsoft.EntityFrameworkCore;
using nz.geek.colin.examples.dotnet.models;

namespace nz.geek.colin.examples.dotnet.data
{
	public class ValueContext : DbContext
	{
		public ValueContext(DbContextOptions<ValueContext> options) : base(options) {}

		public DbSet<Value> Values { get; set; }
	}
}
