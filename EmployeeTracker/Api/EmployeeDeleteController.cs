using EmployeeTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTracker.Controllers
{
    public class EmployeeDeleteController : ControllerBase
    {
        private readonly MockEmployeeDatabase _mockEmployeeDatabase;

        public EmployeeDeleteController()
        {
            _mockEmployeeDatabase = new MockEmployeeDatabase();
        }

        [HttpDelete("api/employees/{id}")]
        public ActionResult Delete(int id)
        {
            _mockEmployeeDatabase.Delete(id);

            return new NoContentResult();
        }
    }
}