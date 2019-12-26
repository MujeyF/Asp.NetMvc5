using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Test.Service;

namespace WebApplication.Test.Models
{
    public class EmployeeRepository
    {
        //public List<Employee> GetEmployees()
        //{
        //    List<Employee> employees = new List<Employee>();
        //    Employee emp = new Employee();
        //    emp.FirstName = "Pascal";
        //    emp.LastName = "Howlett";
        //    emp.Id = 1;
        //    emp.Salary = 25000;
        //    employees.Add(emp);

        //    Employee emp2 = new Employee();
        //    emp2.FirstName = "Casi";
        //    emp2.LastName = "Heibl";
        //    emp2.Id = 2;
        //    emp2.Salary = 26000;
        //    employees.Add(emp2);

        //    Employee emp3 = new Employee();
        //    emp3.FirstName = "Domingo";
        //    emp3.LastName = "Coare";
        //    emp3.Id = 3;
        //    emp3.Salary = 14000;
        //    employees.Add(emp3);

        //    return employees;
        //}
        public  List<Employee> GetEmployees()
        {
            SaleERPDAL saleDAL = new SaleERPDAL();
            return saleDAL.Employees.ToList();
        }
        public Employee SaveEmployee(Employee emp)
        {
            SaleERPDAL saleDAL = new SaleERPDAL();
            saleDAL.Add<Employee>(emp);
            saleDAL.SaveChanges();
            return emp;
        }
    }
}
