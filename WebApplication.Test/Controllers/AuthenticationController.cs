using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nancy.Authentication.Forms;
using WebApplication.Test.Models;

namespace WebApplication.Test.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DoLogin(UserDetails userDetails)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            if (employeeRepository.IsValidUser(userDetails))
            {
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                return RedirectToAction("Index", "Employee");
            }
        }
    }
}