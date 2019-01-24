using EmployeeTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTracker.Controllers
{
    public class EmployeeDeleteController : ControllerBase
    {
        private readonly IMockEmployeeDatabase _mockEmployeeDatabase;

        public EmployeeDeleteController(IMockEmployeeDatabase mockEmployeeDatabase)
        {
            _mockEmployeeDatabase = mockEmployeeDatabase;
        }

        [HttpDelete("api/employees/{id}")]
        public ActionResult Delete(int id)
        {
            _mockEmployeeDatabase.Delete(id);

            return new NoContentResult();
        }
    }
}