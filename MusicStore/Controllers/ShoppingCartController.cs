using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Models;
using System;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly StoreContext _context;

        public ShoppingCartController(StoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ShoppingCart shoppingCart = new ShoppingCart(HttpContext, _context);
            
            HttpContext.Session.SetString("DefaultGretting", "Hola"); //remember: HttpContext can only be reached in controllers
            
            return View(shoppingCart.GetCartItems());
        }
        public async Task<IActionResult> AddToCart(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ShoppingCart shoppingCart = new ShoppingCart(HttpContext, _context);

            var album = await _context.Albums 
                .FirstOrDefaultAsync(a => a.AlbumID == id);

            if (album == null)
            {
                return NotFound();
            }
            shoppingCart.AddToCart(album);
            return RedirectToAction(nameof(Index));   

        }
        public IActionResult RemoveFromCart(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            ShoppingCart shoppingCart = new ShoppingCart(HttpContext, _context);
            shoppingCart.RemoveFromCart(id);

            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveOneFromCart(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            ShoppingCart shoppingCart = new ShoppingCart(HttpContext, _context);
            shoppingCart.RemoveOneFromCart(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
