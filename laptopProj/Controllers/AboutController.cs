using Microsoft.AspNetCore.Mvc;

namespace laptopProj.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
