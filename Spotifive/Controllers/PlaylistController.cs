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
        // GET: Playlist
        public async Task<IActionResult> Index()
        {
            return View(await _context.Playlist.ToListAsync());
        }

        // GET: Playlist/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlist
                .FirstOrDefaultAsync(m => m.ID == id);
            if (playlist == null)
            {
                return NotFound();
            }

            return View(playlist);
        }

        // GET: Playlist/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Playlist/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
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
            return View(playlist);
        }

        // GET: Playlist/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlist.FindAsync(id);
            if (playlist == null)
            {
                return NotFound();
            }
            return View(playlist);
        }

        // POST: Playlist/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,PlaylistName")] Playlist playlist)
        {
            if (id != playlist.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playlist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaylistExists(playlist.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(playlist);
        }

        // GET: Playlist/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playlist = await _context.Playlist
                .FirstOrDefaultAsync(m => m.ID == id);
            if (playlist == null)
            {
                return NotFound();
            }

            return View(playlist);
        }

       
       
        public IActionResult PlaylistSongs(int id) {

          var songs=_context.PlaylistSongs.Include(x => x.Song).Where(entry => entry.PlaylistID == id).Select(entry => entry.Song);
            return View(songs);

        }

        private bool PlaylistExists(int id)
        {
            return _context.Playlist.Any(e => e.ID == id);
        }
    }
}
