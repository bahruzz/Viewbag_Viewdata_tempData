using Microsoft.AspNetCore.Mvc;

namespace Asp.NetIntro_MVC.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
