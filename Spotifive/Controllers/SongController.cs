using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spotifive.Data;
using Spotifive.Models;

namespace Spotifive.Controllers
{
    public class SongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SongController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Song
        public async Task<IActionResult> Index()
        {
            return View(await _context.Song.ToListAsync());
        }

        public IActionResult GetProfile() { return View(); }
        public IActionResult GetOnHomeScreen() { return View(); }
        [Authorize(Roles = "registered user,critic")]

        public IActionResult PlaySong() { return View(); }
        [Authorize(Roles = "registered user")]

        public IActionResult DownloadSong() { return View(); }
        [Authorize(Roles = "registered user")]
        public IActionResult AddToPlaylist() { return View(); }
        [Authorize(Roles = "registered user")]

        public IActionResult GetComments() { return View(); }
        [Authorize(Roles = "registered user")]

        public IActionResult GetGrades() { return View(); }
        [Authorize(Roles = "critic")]
        public IActionResult SetComments() { return View(); }
        [Authorize(Roles = "critic")]
        public IActionResult SetGrades() { return View(); }
        public IActionResult GetDetailsOfSong() { return View(); }
        [Authorize(Roles = "editor")]
        public IActionResult EditSong() { return View(); }



        private bool SongExists(int id)
        {
            return _context.Song.Any(e => e.ID == id);
        }
        [Authorize(Roles = "registered user")]

        public IActionResult CreatePlaylist()
        {
            return View();
        }
        [Authorize(Roles = "registered user")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePlaylist([Bind("ID,PlaylistName")] Playlist playlist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playlist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(playlist);
        }

    }
}
