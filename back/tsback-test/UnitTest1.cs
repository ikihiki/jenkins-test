using System;
using tsback;
using Xunit;

namespace tsback_test
{
    public class UnitTest1
    {
        [Fact]
        public void TestHelloxUnit()
        {
            var target = new Hello();
            Assert.Equal("Hello xUnit", target.SayHello("xUnit"));
        }

                [Fact]
        public void TestHelloxDotnet()
        {
            var target = new Hello();
            Assert.Equal("Hello dotnet", target.SayHello("dotnet"));
        }
    }
}
