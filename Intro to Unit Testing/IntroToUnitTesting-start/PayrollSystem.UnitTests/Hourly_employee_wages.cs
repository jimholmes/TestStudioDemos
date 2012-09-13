using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using UnitTesting101;

namespace PayrollSystem.UnitTests
{
    [TestFixture]
    public class Hourly_employee_wages
    {
        private WageComputer _computer;

        [TestFixtureSetUp]
        public void Run_once_before_any_other_tests()
        {
            _computer = new WageComputer();
        }

        [Test]
        public void Computing_40_hours_at_rate_5_returns_200()
        {
            var wages = _computer.ComputeWages(40, 5, true);

            Assert.AreEqual(200, wages);
        }

        [Test]
        public void Computing_41_hours_at_rate_5_returns_207_5()
        {
            var wages = _computer.ComputeWages(41, 5, true);

            Assert.AreEqual(207.5, wages);
        }

        [Test]
        public void Computing_zero_hours_at_rate_5_returns_0()
        {
            var wages = _computer.ComputeWages(0, 5, true);

            Assert.AreEqual(0, wages);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Computing_negative_hours_throws_argument_exception()
        {
            var wages = _computer.ComputeWages(-4, 5, true);
        }

        [TestCase(40, 5, Result=200)]
        [TestCase(41, 5, Result=207.5)]
        [TestCase(-1, 5, ExpectedException = (typeof(ArgumentException)))]
        public float Compute_wages_matrix_for_hourly_worker(float hours, float rate)
        {
            return _computer.ComputeWages(hours, rate, true);
        }

        [Test]
        public void Compare_two_collections()
        {
            List<int> right = new List<int>();
            right.Add(1);
            right.Add(2);
            right.Add(3);

            List<int> left = new List<int>();
            left.Add(1);
            left.Add(3);
            left.Add(2);

            CollectionAssert.AreEquivalent(left, right);
        }
    }
}
