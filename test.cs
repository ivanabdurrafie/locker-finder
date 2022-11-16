using Xunit;

namespace MyNamespace
{
    public class Test
    {
        [Fact]
        public void TestFunc()
        {
            Assert.Equal(1, Program.returnFloor(5));
            Assert.Equal(2, Program.returnFloor(11));
            Assert.Equal(3, Program.returnFloor(18));
        }
    }
}

