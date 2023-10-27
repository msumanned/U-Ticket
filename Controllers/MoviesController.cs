using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using U_Ticket.Data;

namespace U_Ticket.Controllers
{
    public class MoviesController : Controller
    {
        public MoviesController(AppDbContext context) 
        {
            _context = context;
        }
        private readonly AppDbContext _context;
        public async Task<IActionResult> Index()
        {
            var Movies_name = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
