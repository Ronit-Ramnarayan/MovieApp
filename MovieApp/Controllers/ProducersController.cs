using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;

namespace MovieApp.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Producers.ToList();
            return View();
        }
    }
}
