using Microsoft.AspNetCore.Mvc;

namespace dp7.Controllers
{
    public class ClientPortalController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

		public IActionResult CapitalGainLossStatement()
		{
			return View();
		}
		
		public IActionResult LedgerStatement()
		{
			return View();
		}
		
		public IActionResult TradeConfirmation()
		{
			return View();
		}

		public IActionResult PortfolioReport()
		{
			return View();
		}

        public IActionResult Profile()
        {
            return View();
        }
		
		public IActionResult FundRequisition()
        {
            return View();
        }

        public IActionResult IPOResult()
        {
            return View();
        }
        
        public IActionResult UpcomingIPO()
        {
            return View();
        }

        public IActionResult IPOSubscription()
        {
            return View();
        }
    }
}
