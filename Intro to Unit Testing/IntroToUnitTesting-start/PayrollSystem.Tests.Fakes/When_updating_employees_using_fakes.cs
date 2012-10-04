using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using UnitTesting101.Business;
using UnitTesting101.Contracts;
using UnitTesting101.Domain;

namespace PayrollSystem.Tests.Fakes
{
    [TestFixture]
    public class When_updating_employees_using_fakes
    {
        [Test]
        public void Updated_employee_has_correct_rate()
        {
            int employeeId = 1;
            int oldRate = 5;
            int newRate = 10;

            IUpdateEmployeePermissible stubProvider =
                new UnitTesting101.Contracts.Fakes.StubIUpdateEmployeePermissible()
            {
                CanUpdateEmployeeRateInt32 =
                (targetEmployeeId) => 
                { return true; }
            };

            Employee current = EmployeeFactory.Create(employeeId, "Jim", "Holmes", "Doghouse", oldRate);
            EmployeeUpdater updater = new EmployeeUpdater(stubProvider);

            Employee updated = updater.UpdateEmployeeRate(current, newRate);

            Assert.AreEqual(updated.HourlyRate, newRate);
        }
    }
}
