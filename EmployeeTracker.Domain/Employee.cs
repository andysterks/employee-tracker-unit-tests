using System;

namespace EmployeeTracker.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string JobTitle { get; set; }
        public DateTime HireDate { get; set; }
    }
}
