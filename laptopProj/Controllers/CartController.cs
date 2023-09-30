
using laptopProj.Data;
using laptopProj.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace laptopProj.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CartController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Cart> cartItems = _db.Carttbl.ToList();
            return View(cartItems);
        }

       

            [HttpPost]
            public IActionResult RemoveFromCart(int productId)
            {
                Cart cartItemToRemove = _db.Carttbl.FirstOrDefault(c => c.P_Id == productId);
                if (cartItemToRemove != null)
                {
                    _db.Carttbl.Remove(cartItemToRemove);
                    _db.SaveChanges();
                }

                return RedirectToAction("Index");
            }

 


    }
}

