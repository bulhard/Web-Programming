using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_Students_Homework.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace _04_Students_Homework.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;
        private readonly IConfiguration configuration;

        public StudentController(IStudentService studentService, IConfiguration configuration)
        {
            this.studentService = studentService;
            this.configuration = configuration;
        }

        public IActionResult Index(string fn, string ln)
        {
            ViewData["Title"] = configuration["WebSiteTitle"];

            var students = studentService.GetStudents(fn, ln);

            return View(students);
        }

        public IActionResult Details(int id)
        {
            ViewData["Title"] = configuration["WebSiteTitle"];

            var student = studentService.GetStudent(id);

            return View(student);
        }
    }
}