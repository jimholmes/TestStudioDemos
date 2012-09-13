using System;
using NUnit.Framework;
using UnitTesting101;
using System.Collections.Generic;

namespace PayrollSystem.Tests
{
    [TestFixture]
    public class When_working_with_an_hourly_employee
    {
        private WageComputer _computer;

        [TestFixtureSetUp]
        public void Run_once_before_any_tests()
        {
            _computer = new WageComputer();
        }

        [Test]
        public void Computing_with_40_hours_at_5_rate_returns_200()
        {
            //arrange

            //act 
            var wages = _computer.ComputeWages(40, 5, true);

            //assert
            Assert.AreEqual(200, wages, "40 * 5 == 200");
        }

        [Test]
        public void Computing_with_41_hours_at_5_rate_returns_207_50()
        {
            var wages = _computer.ComputeWages(41, 5, true);

            Assert.AreEqual(207.50, wages);
        }


        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_hours_throws_exception()
        {
            var wages = _computer.ComputeWages(-1, 5, true);
        }

        [TestCase(40, 5, Result=200)]
        [TestCase(41, 5, Result=207.50)]
        [TestCase(-1, 5, ExpectedException=(typeof(ArgumentException)))]
        public float Run_matrix_test(float hours, float rate)
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

            CollectionAssert.AreEquivalent(right, left);
        }


    }
}