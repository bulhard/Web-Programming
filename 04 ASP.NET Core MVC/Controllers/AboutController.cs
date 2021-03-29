using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace _04_ASP.NET_Core_MVC.Controllers
{
    public class AboutController : Controller
    {
        private IConfiguration configuration;

        public AboutController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index(string id, string name)
        {
            string message = configuration.GetValue<string>("message");

            message = configuration["message"];

            return View();
        }
    }
}