using System;

namespace UnitTesting101.Domain
{
    public class Employee
    {
        private float hourlyRate;

        public Employee(int employeeId, string firstName, string lastName, string address,
                        float hourlyRate)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            this.hourlyRate = hourlyRate;
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime LastUpdated { get; set; }

        public float HourlyRate
        {
            get { return hourlyRate; }
        }
    }
}