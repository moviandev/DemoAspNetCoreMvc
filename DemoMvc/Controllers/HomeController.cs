using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;

namespace DemoMvc.Controllers
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
            var movie = new Movie()
            {
                Title = "hi",
                ReleaseDate = DateTime.Now,
                Type = null,
                Ratings = 10,
                Price = 200000
            };
            return RedirectToAction("Privacy", movie);
            return View();
        }

        public IActionResult Privacy(Movie movie)
        {
            foreach (var item in ModelState.Values.SelectMany(m => m.Errors))
                Console.WriteLine(item.ErrorMessage);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
