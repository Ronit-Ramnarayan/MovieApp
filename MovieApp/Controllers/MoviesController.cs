using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;

namespace MovieApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allMovies = _context.Movies.ToList();
            return View();
        }
    }
}
