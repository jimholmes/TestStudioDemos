using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using UnitTesting101;

namespace PayrollSystem.Tests
{
    [TestFixture]
    public class When_working_with_hourly_workers
    {
        WageComputer computer;
        [TestFixtureSetUp]
        public void Run_once_before_ANY_tests()
        {
            computer = new WageComputer();
        }

        [Test]
        public void computing_40_hours_at_rate_5_should_return_200()
        {
            //WageComputer computer = new WageComputer();

            var wages = computer.ComputeWages(40, 5, true);

            Assert.AreEqual(200, wages);
        }

        [Test]
        public void computing_1_hours_at_rate_5_should_return_5()
        {
            //WageComputer computer = new WageComputer();

            var wages = computer.ComputeWages(1, 5, true);

            Assert.AreEqual(5, wages);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_hours_throws_exception()
        {
            var wages = computer.ComputeWages(-1, 5, true);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_rate_throws_exception()
        {
            var wages = computer.ComputeWages(1, -1, true);
        }

        [TestCase(40, 5, Result = 200)]
        [TestCase(41, 5, Result = 207.50)]
        [TestCase(-1, 5, ExpectedException = (typeof(ArgumentException)))]
        public float Run_matrix_test(float hours, float rate)
        {
            return computer.ComputeWages(hours, rate, true);
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

            CollectionAssert.AreEquivalent(right, left);
        }
    }
}
