using EmployeeTracker.Domain;
using System.Linq;
using System.Collections.Generic;

namespace EmployeeTracker.Data
{
    public interface IMockEmployeeDatabase
    {
        List<Employee> Get();
        Employee Get(int id);
        void Modify(int id, Employee employee);
        void Create(Employee employee);
        void Delete(int id);
    }

    public class MockEmployeeDatabase : IMockEmployeeDatabase
    {
        private List<Employee> _employees;

        public MockEmployeeDatabase()
        {
            _employees = new List<Employee>();
        }

        public List<Employee> Get()
        {
            return _employees;
        }

        public Employee Get(int id)
        {
            return _employees.First(x => x.Id == id);
        }

        public void Modify(int id, Employee employee)
        {
            Delete(id);
            Create(employee);
        }

        public void Create(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Delete(int id)
        {
            var employeeToDelete = Get(id);

            _employees.Remove(employeeToDelete);
        }
    }
}
