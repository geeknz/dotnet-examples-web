using nz.geek.colin.examples.dotnet.models;
using System.Linq;

namespace nz.geek.colin.examples.dotnet.data
{
	public static class DbInitializer
	{
		public static void Initialize(ValueContext context)
		{
			context.Database.EnsureCreated();

			if (context.Values.Any()) {
				return;
			}

			context.Values.Add(new Value {
				Id = 1
			});

			context.Values.Add(new Value {
				Id = 2
			});

			context.SaveChanges();
		}
	}
}
