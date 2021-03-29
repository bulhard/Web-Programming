using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_ASP.NET_Core_MVC.Model;
using Microsoft.AspNetCore.Mvc;

namespace _04_ASP.NET_Core_MVC.Controllers
{
    public class StudentController : Controller
    {
        private static IList<StudentViewModel> studentList = new List<StudentViewModel>{
                new StudentViewModel() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new StudentViewModel() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new StudentViewModel() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new StudentViewModel() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new StudentViewModel() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new StudentViewModel() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new StudentViewModel() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            };

        public IActionResult Index()
        {
            return View(studentList);
        }
    }
}