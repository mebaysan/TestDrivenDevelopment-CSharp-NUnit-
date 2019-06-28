using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz method;
        [SetUp]
        public void SetUp()
        {
            method = new FizzBuzz();
            
        }
        [Test]
        public void GetOutPut_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = method.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void GetOutPut_InputIsDivisibleBy3Only_ReturnFizz()
        {
           
            var result = method.GetOutput(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void GetOutPut_InputIsDivisibleBy5Only_ReturnBuzz()
        {
            
            var result = method.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void GetOutPut_InputIsNotDivisibleBy3And5_ReturnTheSameNumber()
        {
            
            var result = method.GetOutput(1);
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
