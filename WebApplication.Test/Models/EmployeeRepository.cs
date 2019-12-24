using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Test.Models
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "Fohnson";
            emp.LastName = "Fernands";
            emp.Salary = 14000;
            employees.Add(emp);
            
            emp = new Employee();
            emp.FirstName = "Michel";
            emp.LastName = "Victol";
            emp.Salary = 37000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "robert";
            emp.LastName = "pattinson";
            emp.Salary = 24000;
            employees.Add(emp);

            return employees;
        }
    }
}
