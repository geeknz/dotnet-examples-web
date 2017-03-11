using WebApp.Controllers;
using Xunit;

namespace WebApp.Tests
{
	public class ValuesControllerTests
	{
		[Fact]
		public void DummyTest1()
		{
			var controller = new ValuesController(null);
			Assert.True(false);
		}

		[Fact]
		public void DummyTest2()
		{
			var controller = new ValuesController(null);
			Assert.True(true);
		}
	}
}
