using Xunit;

namespace Fibonacci.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var results = Compute.Execute(new[] {"44"});
            Assert.Equal(701408733, results[0]);
        }
    }
}
