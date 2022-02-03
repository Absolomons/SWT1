
using NUnit.Framework;
namespace Calculator.Test.Unit

{
    [TestFixture]
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            //Arrange
            var uut = new CalculatorTest.Calculator();
            
            //Act
            double result = uut.Add(12.5, 2.4);

            //Assert
            Assert.That(result, Is.EqualTo(14.9));
        }
    }
}