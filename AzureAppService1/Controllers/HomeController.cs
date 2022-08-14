using AzureAppService1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AzureAppService1.Models.ViewModel.Home;

namespace AzureAppService1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(IndexViewModel view)
        {
            view.NumberC = view.NumberA + view.NumberB;

            if(view.NumberA == 5)
            {
                List<string> ss = null;
                ss.First();
            }

            return View(view);
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