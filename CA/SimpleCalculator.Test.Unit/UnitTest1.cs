using System;
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
        public void Subtract_TwoNegDecNumbers_ResultIsNegativeDifference()
        {
            //Act
            var result = uut.Subtract(-21.5, -3.43);

            //Assert
            Assert.That(result, Is.EqualTo(-18.07));
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
        public void Multiply_TwoNegDecNumbers_ResultIsPos()
        {
            //Act
            var result = uut.Multiply(-2, -5);

            //Assert
            Assert.That(result, Is.Positive);
        }

        [Test]
        public void Multiply_OneNegOnePos_ResultIsNeg()
        {
            //Act
            var result = uut.Multiply(-2, 5);

            //Assert
            Assert.That(result, Is.Negative);
        }
        [Test]
        public void Divide_TwoPosDecNumbers_ResultIsDivided()
        {
            //Act
            var result = uut.Divide(4, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Divide_PosWithNegNumbers_ResultIsDivided()
        {
            //Act
            var result = uut.Divide(6, -2);

            //Assert
            Assert.That(result, Is.EqualTo(-3));
        }

        [Test]
        public void Divide_NegWithNegNumbers_ResultIsDivided()
        {
            //Act
            var result = uut.Divide(-4, -2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Divide_DivisorIsZero_DivideByZeroExceptionThrown()
        {
            //Act and Assert
            Assert.That(() => uut.Divide(5, 0), Throws.TypeOf<DivideByZeroException>());
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

        [Test]
        public void Clear_ClearTheAccumulatorAfterNegativResult_AccumulatorIsZero()
        {
            var resultMultiply = uut.Multiply(-5, 5);
            uut.Clear();

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Clear_ClearTheAccumulatorEvenIfItIsAlreadyCleared_AccumulatorIsZero()
        {
            uut.Clear();
            uut.Clear();

            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
    }
}