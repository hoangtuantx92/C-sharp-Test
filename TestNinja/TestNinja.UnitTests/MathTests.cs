using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;
using System.Linq;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        { 
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnsTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a,b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumber_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            // Assert.That(result, Is.Not.Empty);

            // Assert.That(result.Count(), Is.EqualTo(3));

            // Assert.That(result, Does.Contain(1));
            // Assert.That(result, Does.Contain(3));
            // Assert.That(result, Does.Contain(5));
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
        }

        [Test]
        public void GetOddNumber_IfLimitIsZero_ReturnsEmpty()
        {
            var ressult = _math.GetOddNumbers(0);

            Assert.That(ressult, Is.Empty);
        }

        [Test]
        public void GetOddNumber_IfLimitIsNegative_ReturnsEmpty()
        {
            var ressult = _math.GetOddNumbers(-5);

            Assert.That(ressult, Is.Empty);
        }
    }
}
