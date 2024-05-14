using Asp.NetIntro_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Asp.NetIntro_MVC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderImg> SliderImgs { get; set; }


    }
}
