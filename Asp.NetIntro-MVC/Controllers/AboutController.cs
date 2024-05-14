using Microsoft.AspNetCore.Mvc;

namespace Asp.NetIntro_MVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
