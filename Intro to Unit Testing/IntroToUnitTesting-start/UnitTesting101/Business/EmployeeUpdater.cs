using System;
using System.Security;
using UnitTesting101.Contracts;
using UnitTesting101.Domain;

namespace UnitTesting101.Business
{
    public class EmployeeUpdater
    {
        public Employee UpdateEmployeeRate(Employee targetEmployee, float newRate)
        {
            Employee updatedEmployee;
            if (_updateEmployeeSecurityProvider.CanUpdateEmployeeRate(targetEmployee.EmployeeId))
            //if (true)
            {
                updatedEmployee = new Employee(targetEmployee.EmployeeId, targetEmployee.FirstName,
                                               targetEmployee.LastName,
                                               targetEmployee.Address, newRate);
                updatedEmployee.LastUpdated = DateTime.Now;
            }
            else
            {
                throw new SecurityException(
                    "Invoking user doesn't have permissions to update target target employee. "
                    + targetEmployee);
            }
            return updatedEmployee;
        }




        private readonly IUpdateEmployeePermissible _updateEmployeeSecurityProvider;
              
        public EmployeeUpdater(
            IUpdateEmployeePermissible updateEmployeeSecurityProvider)
        {
            _updateEmployeeSecurityProvider = updateEmployeeSecurityProvider;
        }


        
    }

    
}