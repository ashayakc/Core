using System;
using Xunit;

namespace Logic.Tests
{
    public class LogicTest
    {
        [Fact]
        public void DisplayTest()
        {
            var logicIns = new WebApplication2.Logic.Logic();
            logicIns.Display();
        }
    }
}
