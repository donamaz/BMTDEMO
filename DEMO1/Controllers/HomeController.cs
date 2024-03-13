using DEMO1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DEMO1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        BanMayTinhContext bmt = new BanMayTinhContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var d = bmt.SanPhams.ToList();
            return View(d);
        }

        public IActionResult ctsp(int id) 
        { 
            
            var sp = bmt.SanPhams.FirstOrDefault(s => s.MaSanPham == id);
            return View(sp);
        
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}