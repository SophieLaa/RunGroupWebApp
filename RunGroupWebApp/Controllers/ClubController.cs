using Microsoft.AspNetCore.Mvc;
using RunGroupWebApp.Data;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() //C
        {
            List<Club> clubs = _context.Clubs.ToList(); //M
            return View(clubs); //V
        }

        public IActionResult Detail(int id)
        {
            Club club = _context.Clubs.FirstOrDefault(c => c.Id == id); 
            return View(club);
        }
    }
}
