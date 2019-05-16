using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-5)]
        [TestCase(500)]
        public void DemeritPointsCalculator_WhenCalled_ReturnArgumentOutOfRangeException(int speed)
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(40, 0)]
        [TestCase(65, 0)]
        [TestCase(0, 0)]
        [TestCase(66, 0)]
        [TestCase(68, 0)]
        public void DemeritPointsCalculator_IfLessThanOrEqualToSpeedLimmit_ReturnZero(int speed, int expectResult)
        {
            var demeritPoints = new DemeritPointsCalculator();
            var result = demeritPoints.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectResult));
        }

        [Test]
        public void DemeritPointsCalculator_IfGreaterThanSpeedLimit_ReturnDemeritPoints()
        {
            var demeritPoints = new DemeritPointsCalculator();
            var result = demeritPoints.CalculateDemeritPoints(75);

            Assert.That(result, Is.EqualTo(2));
        }
    }
}
