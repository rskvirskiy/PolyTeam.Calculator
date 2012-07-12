using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;

namespace PolyTeam.Calculator.Test
{
    [TestFixture]
    public class OutputInput_Test
    {
        [Test]
        public void Should_ConsoleOutCalledAtOnce_WhenGenericOutCalled()
        {
            //arrenge
            var MockConsoleOutput = new Mock<ICalculatorOutput>();
            var Distributor = new CalculatorDistributor(MockConsoleOutput.Object);
            //act
            Distributor.GenericOutput(0);
            //assert
            MockConsoleOutput.Verify(x => x.Out(0),Times.Once());
        }

    }
}
