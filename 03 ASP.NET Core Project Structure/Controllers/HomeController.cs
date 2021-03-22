using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// using Microsoft.Extensions.Logging;
using _03_ASP.NET_Core_Project_Structure.Models;

namespace _03_ASP.NET_Core_Project_Structure.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            //EventId eventId = new EventId(1, "Hello world");
            //_logger.Log(LogLevel.Information, "Info");
            //_logger.LogCritical(eventId, "Oups I did it again");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}