using NUnit.Framework;

namespace SimpleCalculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();

        }

        [Test]
        public void Add_TwoPosDecNumbers_ResultIsSum()
        {
            //Act
            var result = uut.Add(3.43, 21.5);

            //Assert
            Assert.That(result,Is.EqualTo(24.93));
        }

        [Test]
        public void Add_OnePosOneNegDecNumbers_ResultIsDifference()
        {
            //Act
            var result = uut.Add(-3.43, 21.5);

            //Assert
            Assert.That(result, Is.EqualTo(18.07));
        }

        [Test]
        public void Subtract_TwoPosDecNumbers_ResultIsDifference()
        {
            //Act
            var result = uut.Subtract(21.5, 3.43);

            //Assert
            Assert.That(result, Is.EqualTo(18.07));
        }

        [Test]
        public void Multiply_TwoPosDecNumbers_ResultIsMultiplied()
        {
            //Act
            var result = uut.Multiply(2, 5);

            //Assert
            Assert.That(result, Is.EqualTo(10));
        }
    }
}