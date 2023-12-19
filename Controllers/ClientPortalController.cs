using Microsoft.AspNetCore.Mvc;

namespace dp7.Controllers
{
    public class ClientPortalController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
