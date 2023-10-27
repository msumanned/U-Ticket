using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using U_Ticket.Data;

namespace U_Ticket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController (AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var cinemas_data = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
