using EmployeeTracker.Data;
using EmployeeTracker.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeTracker.Controllers
{
    public class EmployeeGetController : ControllerBase
    {
        private readonly IMockEmployeeDatabase _mockEmployeeDatabase;

        public EmployeeGetController(IMockEmployeeDatabase mockEmployeeDatabase)
        {
            _mockEmployeeDatabase = mockEmployeeDatabase;
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