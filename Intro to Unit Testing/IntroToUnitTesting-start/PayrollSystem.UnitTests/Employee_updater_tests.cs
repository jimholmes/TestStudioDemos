using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;
using UnitTesting101.Business;
using UnitTesting101.Contracts;
using UnitTesting101.Domain;

namespace PayrollSystem.UnitTests
{
    [TestFixture]
    class Employee_updater_tests
    {
        [Test]
        public void Updated_employee_has_correct_new_rate()
        {
            var stubProvider = MockRepository.GenerateStub<IUpdateEmployeePermissible>();
            stubProvider.Stub(x => x.CanUpdateEmployeeRate(1)).Return(true);

            Employee emp = new Employee(1, "Jim", "Holmes", "Doghouse", 5);
            EmployeeUpdater updater = new EmployeeUpdater(stubProvider);

            Employee updatedEmp = updater.UpdateEmployeeRate(emp, 10);

            Assert.That(updatedEmp.HourlyRate, Is.EqualTo(10));
        }

        [Test]
        public void Verify_that_security_provider_is_called()
        {
            var mockProvider = MockRepository.GenerateMock<IUpdateEmployeePermissible>();
            mockProvider.Expect(x => x.CanUpdateEmployeeRate(1)).Return(true);

            Employee currentEmployee = new Employee(1, "Jim", "Holmes", "Doghouse", 5);
            EmployeeUpdater updater = new EmployeeUpdater(mockProvider);

            Employee updatedEmployee = updater.UpdateEmployeeRate(currentEmployee, 10);

            mockProvider.VerifyAllExpectations();
        }
    }
}
