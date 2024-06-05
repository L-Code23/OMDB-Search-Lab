using Microsoft.AspNetCore.Mvc;
using Searching_OMDB.Models;
using System.Diagnostics;

namespace Searching_OMDB.Controllers
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
        [HttpGet]
        public IActionResult MovieSearch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieSearch(string title)
        {
            OMDb result = OMDbDAL.GetMovie(title);
            return View(result);
        }

        [HttpGet]
        public IActionResult MovieNight()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult MovieNight(string title1, string title2, string title3)
        {
            
           OMDb Movie1 = OMDbDAL.GetMovie(title1);
            OMDb Movie2 =OMDbDAL.GetMovie(title2);
           OMDb Movie3 = OMDbDAL.GetMovie(title3);
            List<OMDb> result =   new List <OMDb>();
            
            return View(result);
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
