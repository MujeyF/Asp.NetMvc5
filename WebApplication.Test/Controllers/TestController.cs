using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Test.Models;
using WebApplication.Test.ViewModels;

namespace WebApplication.Test.Controllers
{
    class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello MVC From Test.GetStringAction ==";
        }
        [NonAction]
        public string GetCustomer()
        {
            Customer c = new Customer();
            c.Name = "Mujey";
            c.Age = 19;
            return c.Name.ToString() + c.Age.ToString();
        }
        public IActionResult GetView()
        {
            Employee employee = new Employee();
            employee.FirstName = "Mujey";
            employee.LastName = "Fang";
            employee.Salary = 10000;
            // ViewBag 是 ViewData 的一种语法糖
            //ViewData["Employee"] = employee;
            //ViewBag.Employee = employee;
            return View("MyView",employee);
        }
        // VM 形式
        public IActionResult GetEmployee()
        {
            Employee emp = new Employee();
            emp.FirstName = "Mujey";
            emp.LastName = "Fang";
            emp.Salary = 10000;

            EmployeeViewModel viewModel = new EmployeeViewModel();
            viewModel.FullName = emp.FirstName + emp.LastName;
            viewModel.Salary = emp.Salary.ToString("C");
            if (emp.Salary > 15000)
            {
                viewModel.SalaryColor = "yellow";
            }
            else
            {
                viewModel.SalaryColor = "gray";
            }
            return View("EmployeeView",viewModel);

        }

        public IActionResult Employees()
        {
            List<EmployeeViewModel> vm_employees = new List<EmployeeViewModel>();
            EmployeeRepository employeeRepository = new EmployeeRepository();
            foreach (var i in employeeRepository.GetEmployees())
            {
                EmployeeViewModel vm_employee = new EmployeeViewModel();
                vm_employee.FullName = i.FirstName +" "+ i.LastName;
                vm_employee.Salary = i.Salary.ToString("C");
                if (i.Salary > 15000)
                {
                    vm_employee.SalaryColor = "yellow";
                }
                else
                {
                    vm_employee.SalaryColor = "gray";
                }
                vm_employees.Add(vm_employee);
            }

            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            employeeListViewModel.Employees = vm_employees;

            return View(employeeListViewModel);
        }
    }
}
