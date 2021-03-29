using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_ASP.NET_Core_MVC.Model;
using Microsoft.AspNetCore.Mvc;

namespace _04_ASP.NET_Core_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ObjectResult Index()
        {
            EmployeeViewModel employee = new EmployeeViewModel
            {
                Id = 1,
                Name = "John Smith"
            };

            return new ObjectResult(employee);
        }

        public JsonResult Index1()
        {
            EmployeeViewModel employee = new EmployeeViewModel
            {
                Id = 1,
                Name = "John Smith"
            };

            return new JsonResult(employee);
        }
    }
}