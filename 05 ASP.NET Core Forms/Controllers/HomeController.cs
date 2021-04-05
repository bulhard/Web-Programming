using _05_ASP.NET_Core_Forms.Models.Home;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace _05_ASP.NET_Core_Forms.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        public HomeController(IWebHostEnvironment environment)
        {
            hostingEnvironment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form1(string firstName, string lastName, int category, string email)
        {
            PersonViewModel person = new PersonViewModel();

            person.FirstName = firstName;
            person.LastName = lastName;
            person.Category = category;

            return View(person);
        }

        [HttpPost]
        public IActionResult Form1WithModel(PersonViewModel person)
        {
            return RedirectToAction(nameof(Form1));
        }

        public IActionResult Form2()
        {
            return View();
        }

        public IActionResult Form4()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Form4(IFormFile photo)
        {
            if (photo.Length > 0)
            {
                var uniqueFileName = GetUniqueFileName(photo.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploads, uniqueFileName);

                await photo.CopyToAsync(new FileStream(filePath, FileMode.Create));
            }

            return View();
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}