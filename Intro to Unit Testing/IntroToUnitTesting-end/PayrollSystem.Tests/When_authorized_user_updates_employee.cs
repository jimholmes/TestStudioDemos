using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;
using UnitTesting101.Business;
using UnitTesting101.Contracts;
using UnitTesting101.Domain;

namespace PayrollSystem.Tests
{
    [TestFixture]
    public class When_authorized_user_updates_employee
    {
        [Test]
        public void Updated_employee_has_correct_rate()
        {
            int userId = 1;
            int oldRate = 5;
            int newRate = 10;

            var stubProvider = 
                MockRepository.GenerateStub<IUpdateEmployeePermissible>();
            stubProvider.Stub(x => 
                x.CanUpdateEmployeeRate(userId)).
                Return(true);

            Employee current = new Employee(userId, "Jim", "Holmes", "Doghouse", oldRate);
            EmployeeUpdater updater = new EmployeeUpdater(stubProvider);

            Employee updated = updater.UpdateEmployeeRate(current, newRate);

            Assert.AreEqual(updated.HourlyRate, newRate);
        }

        /*
         * This test currently fails because the call to the security provider
         * on line 12 of EmployeeUpdater is commented out. The provider's not
         * called, so the expectation set below in mockProvider.Expect... is
         * never met.
         */
        [Test]
        public void Verify_security_provider_is_called()
        {
            int userId = 1;
            int oldRate = 5;
            int newRate = 10;

            var mockProvider = 
                MockRepository.GenerateMock<IUpdateEmployeePermissible>();
            mockProvider.Expect(x => 
                x.CanUpdateEmployeeRate(userId)).Return(true);

            Employee current = new Employee(userId, "Jim", "Holmes", "Doghouse", oldRate);
            EmployeeUpdater updater = new EmployeeUpdater(mockProvider);

            Employee updated = updater.UpdateEmployeeRate(current, newRate);

            mockProvider.VerifyAllExpectations();
        }
    }
}
