using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee(){ Id=1,Name="Lokesh",Department="IT",Email="Lokii@gmail"},
                new Employee(){ Id=1,Name="Ashish",Department="Hr",Email="Lokii@gmail"}
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(e => e.Id ==id);
        }
    }
}
