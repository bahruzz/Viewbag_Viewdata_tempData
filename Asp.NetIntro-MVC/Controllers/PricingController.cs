using Microsoft.AspNetCore.Mvc;

namespace Asp.NetIntro_MVC.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
