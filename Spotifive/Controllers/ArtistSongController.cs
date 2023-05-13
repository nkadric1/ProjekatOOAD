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
    public class ArtistSongController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtistSongController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ArtistSong
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ArtistSongs.Include(a => a.Artist).Include(a => a.Song);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ArtistSong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artistSongs = await _context.ArtistSongs
                .Include(a => a.Artist)
                .Include(a => a.Song)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (artistSongs == null)
            {
                return NotFound();
            }

            return View(artistSongs);
        }

        // GET: ArtistSong/Create
        public IActionResult Create()
        {
            ViewData["ArtistID"] = new SelectList(_context.Artist, "ID", "ID");
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID");
            return View();
        }

        // POST: ArtistSong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ArtistID,SongID")] ArtistSongs artistSongs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artistSongs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistID"] = new SelectList(_context.Artist, "ID", "ID", artistSongs.ArtistID);
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID", artistSongs.SongID);
            return View(artistSongs);
        }

        // GET: ArtistSong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artistSongs = await _context.ArtistSongs.FindAsync(id);
            if (artistSongs == null)
            {
                return NotFound();
            }
            ViewData["ArtistID"] = new SelectList(_context.Artist, "ID", "ID", artistSongs.ArtistID);
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID", artistSongs.SongID);
            return View(artistSongs);
        }

        // POST: ArtistSong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ArtistID,SongID")] ArtistSongs artistSongs)
        {
            if (id != artistSongs.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artistSongs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtistSongsExists(artistSongs.ID))
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
            ViewData["ArtistID"] = new SelectList(_context.Artist, "ID", "ID", artistSongs.ArtistID);
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID", artistSongs.SongID);
            return View(artistSongs);
        }

        // GET: ArtistSong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artistSongs = await _context.ArtistSongs
                .Include(a => a.Artist)
                .Include(a => a.Song)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (artistSongs == null)
            {
                return NotFound();
            }

            return View(artistSongs);
        }

        // POST: ArtistSong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artistSongs = await _context.ArtistSongs.FindAsync(id);
            _context.ArtistSongs.Remove(artistSongs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtistSongsExists(int id)
        {
            return _context.ArtistSongs.Any(e => e.ID == id);
        }
    }
}
