using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Test.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(n => n.Id == id); 
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees;
        }
    }
}
