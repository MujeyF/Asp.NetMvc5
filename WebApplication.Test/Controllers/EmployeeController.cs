using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Test.Models;
using WebApplication.Test.ViewModels;
using System.Data.SqlClient;
using WebApplication.Test.Service;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication.Test.Controllers
{

    public class EmployeeController : Controller
    {
        //public IActionResult GetView()
        //{
        //    Employee employee = new Employee();
        //    employee.FirstName = "Mujey";
        //    employee.LastName = "Fang";
        //    employee.Salary = 10000;
        //    // ViewBag 是 ViewData 的一种语法糖
        //    //ViewData["Employee"] = employee;
        //    //ViewBag.Employee = employee;
        //    return View("MyView", employee);
        //}
        //public IActionResult GetEmployee()
        //{
        //    Employee emp = new Employee();
        //    var employees = new EmployeeViewModel();
        //    employees.Salary = emp.Salary.ToString("C");
        //    employees.SalaryColor = "gray";
        //    if (emp.Salary>15000)
        //    {
        //        employees.SalaryColor = "yellow";
        //    }

        //    var employeeList = new EmployeeListViewModel();
        //    employeeList.Employees.Add(employees);
            
        //    return View(employeeList);
        //}

        [Authorize]
        public IActionResult Index()
        {
            List<EmployeeViewModel> vm_employees = new List<EmployeeViewModel>();
            EmployeeRepository employeeRepository = new EmployeeRepository();
            foreach (var i in employeeRepository.GetEmployees())
            {
                EmployeeViewModel vm_employee = new EmployeeViewModel();
                vm_employee.FullName = i.FirstName + " " + i.LastName;
                vm_employee.Salary = i.Salary.ToString("C");
                if (i.Salary > 15000)
                {
                    vm_employee.SalaryColor = "yellow";
                }
                else
                {
                    vm_employee.SalaryColor = "gray";
                    vm_employee.FontColor = "white";

                }
                vm_employees.Add(vm_employee);
            }
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            employeeListViewModel.Employees = vm_employees;

            return View("index",employeeListViewModel);
        }
        public IActionResult AddNew()
        {
            return View("CreateEmployee",new CreateEmployeeViewModel());
        }
        public IActionResult SaveEmployee(Employee employee , string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if(ModelState.IsValid)
                    {
                        var employeeRepository = new EmployeeRepository();
                        employeeRepository.SaveEmployee(employee);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        var createEmployeeVM = new CreateEmployeeViewModel();
                        createEmployeeVM.FirstName = employee.FirstName;
                        createEmployeeVM.LastName = employee.LastName;
                        if (!employee.Salary.Equals(null))
                        {
                            createEmployeeVM.Salary = employee.Salary.ToString();
                        }
                        else
                        {
                            createEmployeeVM.Salary = ModelState["Salary"].AttemptedValue;
                        }
                        return View("CreateEmployee", createEmployeeVM);
                    }
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }
    }
}
