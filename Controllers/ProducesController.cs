using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using U_Ticket.Data;

namespace U_Ticket.Controllers
{
    public class ProducesController : Controller
    {
        private readonly AppDbContext _context;
        public ProducesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var producer_data = await _context.Producers.ToListAsync();
            return View();
        }
    }
}
