using Asp.NetIntro_MVC.Data;
using Asp.NetIntro_MVC.Models;
using Asp.NetIntro_MVC.ViewModels;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp.NetIntro_MVC.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
            
        public async Task<IActionResult> Index()
        {
            
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            
           
            return View(sliders);
        }

       
    }
}
