using CalendarTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarTest.Controllers
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

        public IActionResult Calendar()
        {
            return View();
        }

        public JsonResult GetCalendarData()
        {
            var eventData = new List<CalendarModel>{
                new CalendarModel{Id = 1, Title = "3 Appointments", Start = "2022-06-11T10:00:00"},
                new CalendarModel{Id = 2, Title = "1 Appointments", Start = "2022-06-12T10:00:00"},
                new CalendarModel{Id = 3, Title = "4 Appointments", Start = "2022-06-12T11:00:00"},
                new CalendarModel{Id = 4, Title = "1 Appointments", Start = "2022-06-12T13:00:00"},
                new CalendarModel{Id = 5, Title = "1 Appointments", Start = "2022-06-12T14:00:00"},
                new CalendarModel{Id = 6, Title = "2 Appointments", Start = "2022-06-12T16:00:00"},
                new CalendarModel{Id = 7, Title = "1 Appointments", Start = "2022-06-13T12:00:00"}
            };
            return Json(eventData);
        }
    }
}
