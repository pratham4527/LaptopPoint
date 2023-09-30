


using laptopProj.Data;
using laptopProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace laptopProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Laptops> laptops = _db.Laptopstbl.ToList();
            return View(laptops);
        }

      
        public IActionResult AddToCart(int id)
        {
            Laptops laptopToAdd = _db.Laptopstbl.FirstOrDefault(l => l.Id == id);
            if (laptopToAdd != null)
            {
                Cart cartItem = new Cart
                {
                    P_Name = laptopToAdd.Name,
                    Price = laptopToAdd.Price,
                    Quantity = 1 // You can adjust this based on your requirements
                };

                _db.Carttbl.Add(cartItem);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        // Other actions...

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
