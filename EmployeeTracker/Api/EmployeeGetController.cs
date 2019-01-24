using EmployeeTracker.Data;
using EmployeeTracker.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeTracker.Controllers
{
    public class EmployeeGetController : ControllerBase
    {
        private readonly MockEmployeeDatabase _mockEmployeeDatabase;

        public EmployeeGetController()
        {
            _mockEmployeeDatabase = new MockEmployeeDatabase();
        }

        [HttpGet("api/employees")]
        public ActionResult<List<Employee>> Get()
        {
            return _mockEmployeeDatabase.Get();
        }

        [HttpGet("api/employees/{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return _mockEmployeeDatabase.Get(id);
        }
    }
}