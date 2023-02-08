using FizzBuzz;
using NUnit.Framework;


namespace FizzBuzzTest
{
    public class Tests
    {
        private FizzBuzzClass _fizzBuzz;

        [SetUp]
        public void Setup()
        {
             _fizzBuzz = new FizzBuzzClass();
        }

        [Test]
        public void ShouldReturn1WhenValueIs1()
        {
            //Arrange            
            int number = 1;
            
            //Act
            var result = _fizzBuzz.GetValue();

            //Assert
            Assert.AreEqual(number, result[number-1]);
        }
        [Test]
        public void ShouldReturnFizzWhenValueIs3()
        {
            //Arrange
            int number = 3;

            //Act
            var result = _fizzBuzz.GetValue();

            //Assert
            Assert.AreEqual("Fizz", result[number - 1]);
        }
        [Test]
        public void ShouldReturnBuzzWhenValueIs5()
        {
            //Arrange
            int number = 5;

            //Act
            var result = _fizzBuzz.GetValue();

            //Assert
            Assert.AreEqual("Buzz", result[number - 1]);
        }
        [Test]
        public void ShouldReturnFizzBuzzWhenValueIs15()
        {
            //Arrange
            int number = 15;

            //Act
            var result = _fizzBuzz.GetValue();

            //Assert
            Assert.AreEqual("FizzBuzz", result[number - 1]) ;
        }

        [TestCase(30, ExpectedResult = "FizzBuzz")]
        [TestCase(27, ExpectedResult = "Fizz")]
        [TestCase(20, ExpectedResult = "Buzz")]
        [TestCase(34, ExpectedResult = "34")]
        public string ReturnValueInString(int number)
        {
            var result = _fizzBuzz.GetValue();

            return result[number - 1].ToString();
        }
    }
}