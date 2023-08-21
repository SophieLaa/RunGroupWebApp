using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;
using RunGroupWebApp.Interfaces;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubRepository _clubRepository;

        public ClubController( IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }
         
        public async Task<IActionResult> Index() //C
        {
           IEnumerable<Club> clubs = await _clubRepository.GetAll();
            return View(clubs); //V
        }

        public async Task<IActionResult> Detail(int id)
        {
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create (Club Club)
        {
            if (!ModelState.IsValid)
            {
                return View(Club);
            }
            _clubRepository.Add(Club);
            return RedirectToAction("Index");
        }
    }
}
