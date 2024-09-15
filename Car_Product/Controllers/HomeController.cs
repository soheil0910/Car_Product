using Car_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Car_Product.Data;

namespace Car_Product.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private CarContext _carDb;
        public HomeController(ILogger<HomeController> logger, CarContext obj)
        {
            _logger = logger;
            _carDb = obj;
        }



  

        public IActionResult Index()
        {
            var produc = _carDb.Product; 
            return View(produc);
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
