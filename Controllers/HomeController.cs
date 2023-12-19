using dp7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dp7.Controllers
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
        public IActionResult Contact()
        {
            return View();
        }

		public IActionResult Downloads()
		{
			return View();
		}

		public IActionResult CompanyBoard()
		{
			return View();
		}
        
        public IActionResult ServiceDetails()
		{
			return View();
		}

        public IActionResult CompanyAtAGlance()
        {
            return View();
        }
        
        public IActionResult CompanyBoardProfile()
        {
            return View();
        }
        public IActionResult CorporateProfile()
        {
            return View();
        }
		public IActionResult NewBoAccount()
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