using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleApi.test
{
    public class UnitTest1
    {

        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue = controller.Get(2);
            Assert.Equal("Arobas Luhandu", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
