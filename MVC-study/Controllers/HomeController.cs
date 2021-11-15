using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_study.Models;
using System;
using System.Diagnostics;

namespace MVC_study.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        [HttpPost]
        public IActionResult Form1(FormModel model)
        {
            DateTime today = DateTime.Today;

            string yourBirhday = model.Date;
            DateTime compiledDate = Convert.ToDateTime(yourBirhday);

            DateTime birthdayDays = compiledDate;

            int numDays = (today - birthdayDays).Days;
        

            bool isLeapYear = false;

            if (DateTime.IsLeapYear(compiledDate.Year))
            {
                isLeapYear = true;
            }

            ViewBag.LeftDays = numDays;
            ViewBag.leapYear = isLeapYear ? "Tak" : "Nie" ;

            return View(model);
        }
    }
}
