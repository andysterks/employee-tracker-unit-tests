using EmployeeTracker.Data;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeTracker.Controllers
{
    public class EmployeePutController : Controller
    {
        private readonly MockEmployeeDatabase _mockEmployeeDatabase;

        public EmployeePutController()
        {
            _mockEmployeeDatabase = new MockEmployeeDatabase();
        }

        [HttpPut("api/employees/{id}")]
        public void Put(int id, [FromBody] EmployeePutRequest employeeRequest)
        {
            var employee = _mockEmployeeDatabase.Get(id);

            employee.Name = employeeRequest.Name;
            employee.Birthdate = employeeRequest.Birthdate;
            employee.Gender = employeeRequest.Gender;
            employee.JobTitle = employeeRequest.JobTitle;
            employee.HireDate = employeeRequest.HireDate;


            _mockEmployeeDatabase.Modify(id, employee);
        }

        public class EmployeePutRequest
        {
            public string Name { get; set; }
            public DateTime Birthdate { get; set; }
            public string Gender { get; set; }
            public string JobTitle { get; set; }
            public DateTime HireDate { get; set; }
        }
    }
}