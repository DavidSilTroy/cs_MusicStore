using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Components
{
    [ViewComponent(Name = "GenreMenu")]
    public class GenreMenuComponent : ViewComponent
    {
        private readonly StoreContext _context;
        public GenreMenuComponent(StoreContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var cart = new ShoppingCart(HttpContext, _context);

            //ViewData["CartCount"] = cart.GetCount();
            var genres = await _context.Genres.OrderBy(a => a.Name).Take(8).ToListAsync();

            return View(genres);
        } 
    }
}
 