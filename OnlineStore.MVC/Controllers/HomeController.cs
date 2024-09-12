using Microsoft.AspNetCore.Mvc;
using OnlineStore.MVC.Models;
using System.Diagnostics;
using OnlineStore.AppServices.Attributes.Repositories;

namespace OnlineStore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAttributesRepository _attributesRepository;

        public HomeController(ILogger<HomeController> logger, IAttributesRepository attributesRepository)
        {
            _logger = logger;

            _attributesRepository = attributesRepository;
        }

        public async Task<IActionResult> Index()
        {
            var attribute = await _attributesRepository.GetAsync(1);
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
