using UnitTesting101.Domain;

namespace PayrollSystem.Tests.Fakes
{
    public class EmployeeFactory
    {
        public static Employee Create(int employeeId, string fName, string lName, string address, int rate)
        {
            return new Employee(employeeId, fName, lName, address, rate);
        }
    }
}