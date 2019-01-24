using System;
using EmployeeTracker.Data;
using EmployeeTracker.Domain;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTracker.Controllers
{
    public class EmployeePostController : ControllerBase
    {
        private readonly IMockEmployeeDatabase _mockEmployeeDatabase;

        public EmployeePostController(IMockEmployeeDatabase mockEmployeeDatabase)
        {
            _mockEmployeeDatabase = mockEmployeeDatabase;
        }

        [HttpPost("api/employees")]
        public ActionResult Post([FromBody]EmployeePostRequest request)
        {
            var employee = new Employee
            {
                Name = request.Name,
                Birthdate = request.Birthdate,
                Gender = request.Gender,
                JobTitle = request.JobTitle,
                HireDate = request.HireDate
            };

            _mockEmployeeDatabase.Create(employee);

            return new CreatedResult($"api/employees/{employee.Id}", employee);
        }

        public class EmployeePostRequest
        {
            public string Name { get; set; }
            public DateTime Birthdate { get; set; }
            public string Gender { get; set; }
            public string JobTitle { get; set; }
            public DateTime HireDate { get; set; }
        }
    }
}