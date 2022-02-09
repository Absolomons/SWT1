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
        public void Add_TwoNegDecNumbers_ResultIsNegativeSum()
        {
            //Act
            var result = uut.Add(-3.43, -21.5);

            //Assert
            Assert.That(result, Is.EqualTo(-24.93));
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
        public void Subtract_OnePosOneNegDecNumbers_ResultIsSum()
        {
            //Act
            var result = uut.Subtract(21.5, -3.43);

            //Assert
            Assert.That(result, Is.EqualTo(24.93));
        }

        [Test]
        public void Subtract_TwoNegDecNumbers_ResultIsNegativeSum()
        {
            //Act
            var result = uut.Subtract(-21.5, -3.43);

            //Assert
            Assert.That(result, Is.EqualTo(-24.93));
        }

        [Test]
        public void Multiply_TwoPosDecNumbers_ResultIsMultiplied()
        {
            //Act
            var result = uut.Multiply(2, 5);

            //Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Divide_Two_PosDecNumvers_ResultIsDivided()
        {
            //Act
            var result = uut.Divide(4, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Accumulator_CheckTheAccumulatorAfterAdd_AccumulatorIsResult()
        {
            var resultAdd = uut.Add(10, 7);

            Assert.That(uut.Accumulator, Is.EqualTo(resultAdd));
        }

        [Test]
        public void Clear_ClearTheAccumulatorAfterMultiply_AccumulatorIsZero()
        {
            var resultMultiply = uut.Multiply(5, 7);
            uut.Clear();

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
    }
}