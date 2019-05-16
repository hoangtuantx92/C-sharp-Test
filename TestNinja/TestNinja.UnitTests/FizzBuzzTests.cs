using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    /// <summary>
    /// Summary description for FizzBuzzTests
    /// </summary>
    [TestFixture]
    public class FizzBuzzTests
    {
       [Test]
       public void GetOutPut_WhenCalled_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        public void GetOutPut_WhenCalled_ReturnOnlyFizz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        [TestCase(5)]
        [TestCase(25)]
        public void GetOutPut_WhenCalled_ReturnOnlyBuzz(int number)
        {
            var result = FizzBuzz.GetOutput(number);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutPut_WhenCalled_ReturnsOriginalNumber()
        {
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
