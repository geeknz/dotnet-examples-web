using nz.geek.colin.examples.dotnet;
using Xunit;

namespace test.nz.geek.colin.examples.dotnet
{
    public class ValuesControllerTests
    {
        [Fact]
        public void DummyTest1()
        {
            var controller = new ValuesController();
            Assert.True(false);
        }

        [Fact]
        public void DummyTest2()
        {
            var controller = new ValuesController();
            Assert.True(true);
        }
    }
}
