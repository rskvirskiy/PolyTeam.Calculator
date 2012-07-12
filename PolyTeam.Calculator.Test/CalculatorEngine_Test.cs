
using NUnit.Framework;
using System;

namespace PolyTeam.Calculator.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void ShouldReturn5WhenAdd2To3()
        {
            //arrange
            var calculator = new CalculatorEngine();

            //act
            Int32 realExeption = calculator.Add(2, 3);
            Int32 simulateExeption = 2 + 3;

            //assert
            Assert.AreEqual(realExeption,simulateExeption);
        }
        [Test]
        public void ShouldReturn2WhenSubstract7To5()
        {
            //arrange
            var calculator = new CalculatorEngine();

            //act
            Int32 realExeption = calculator.Substract(7, 5);
            Int32 simulateExeption = 7 - 5;

            //assert
            Assert.AreEqual(realExeption, simulateExeption);
        }
        [Test]
        public void ShouldReturn15WhenMultiply5To3()
        {
            //arrange
            var calculator = new CalculatorEngine();

            //act
            Int32 realExeption = calculator.Multiply(5, 3);
            Int32 simulateExeption = 5 * 3;

            //assert
            Assert.AreEqual(realExeption, simulateExeption);
        }

        [Test]
        public void ShouldReturn7WhenDivide35To5()
        {
            //arrange
            var calculator = new CalculatorEngine();

            //act
            Int32 realExeption = calculator.Divide(35, 5);
            Int32 simulateExeption = 35 / 5;

            //assert
            Assert.AreEqual(realExeption, simulateExeption);
        }
    }
}
