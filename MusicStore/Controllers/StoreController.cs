using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        private readonly StoreContext _context;

        //public int Albums { get; private set; }

        public StoreController(StoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ListGenres()
        {
            var genres = await _context.Genres.OrderBy(a => a.Name).ToListAsync();

            return View(genres);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Albums
                .Include(a => a.Artist)
                .Include(a => a.Genre)
                .FirstOrDefaultAsync(m => m.AlbumID == id);

            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }
        public async Task<IActionResult> ListAlbums(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var albums = await _context.Albums
                .Include(a => a.Artist)
                .Include(a => a.Genre)
                .ToListAsync(); 

            if (albums == null)
            {
                return NotFound();
            }

            ViewData["dato"] = albums.FindAll(a => a.GenreID == id);

            return View(albums.FindAll(a => a.GenreID == id));
        }
    }
}
