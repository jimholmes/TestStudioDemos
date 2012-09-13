using System;
using UnitTesting101.Contracts;
using UnitTesting101.Domain;

namespace UnitTesting101.Providers
{
    public class UpdateEmployeeSecurityProvider : IUpdateEmployeePermissible
    {
        public bool CanUpdateEmployeeRate(int employeeId)
        {
            return true;
        }
    }
}
