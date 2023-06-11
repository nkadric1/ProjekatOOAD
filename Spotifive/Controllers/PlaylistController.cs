using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spotifive.Data;
using Spotifive.Models;

namespace Spotifive.Controllers
{
    [Authorize(Roles ="RegisteredUser")]
    public class PlaylistController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlaylistController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Playlist() { return View(await _context.Playlist.ToListAsync()); }

          public IActionResult GetPartialView(string para)
        {
            //get data
            var model = _context.Song.Where(x => x.SongName.Contains(para)).ToList();
            return PartialView("_PopView", model);
        }
       
        public IActionResult PlaylistSongs(int id) {

          var songs=_context.PlaylistSongs.Include(x => x.Song).Where(entry => entry.PlaylistID == id).Select(entry => entry.Song);
            return View(songs);

        }
        // GET: Playlist/Create
        public IActionResult Create()
        {
            return RedirectToAction("Playlist", "Playlist");
        }

        // POST: Playlist/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,PlaylistName")] Playlist playlist)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                playlist.Uid = userId;
                _context.Add(playlist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Playlist));
            }
            return RedirectToAction("Playlist", "Playlist");
        }

    }
}
