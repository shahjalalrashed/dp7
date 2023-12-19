using Microsoft.AspNetCore.Mvc;

namespace dp7.Controllers
{
	public class DSEController : Controller
	{
		public IActionResult Price()
		{
			return View();
		}

        public IActionResult News()
        {
            return View();
        }
    }
}
