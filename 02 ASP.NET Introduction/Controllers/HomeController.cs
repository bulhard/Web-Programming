using _02_ASP.NET_Introduction.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace _02_ASP.NET_Introduction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Students/")]
        public IActionResult Students()
        {
            StudentsViewModel studentsViewModel = new StudentsViewModel();

            studentsViewModel.Class = "Web Development";

            studentsViewModel.Students.Add(new Student
            {
                FirstName = "John",
                LastName = "Smith",
                StudentNumber = "1"
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Jane",
                LastName = "Smith",
                StudentNumber = "2"
            });
            studentsViewModel.Students.Add(new Student
            {
                FirstName = "Johny",
                LastName = "Bravo",
                StudentNumber = "3"
            });

            return View(studentsViewModel);
        }
    }
}