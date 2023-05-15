using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spotifive.Data;
using Spotifive.Models;

namespace Spotifive.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtistController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Artist.ToListAsync());
        }

        public IActionResult GetProfile() { return View(); }
        public IActionResult SearchArtist() { return View(); }

        public IActionResult GetArtistScreen() { return View(); }
        public IActionResult OnHomeClick() { return View(); }

        public IActionResult OnPlaylistClick() { return View(); }


    }
}
