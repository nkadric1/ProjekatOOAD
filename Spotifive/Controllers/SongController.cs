using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
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

       /* // GET: Song
        public async Task<IActionResult> Index()
        {
            return View(await _context.Song.ToListAsync());
        }
       */
       /* // GET: Song/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song
                .FirstOrDefaultAsync(m => m.ID == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }
       */
        // GET: Song/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Song/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Editor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Song([Bind("ID, SongName, DateRelease, Genre, CodeQR, LinkYT, DriveLink, Image")] Song song)
        {
            if (ModelState.IsValid)
            {
                _context.Add(song);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Song));
            }
            return View(song);
        }

        [Authorize(Roles ="Editor")]
        public IActionResult Edit() { return View(); }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit([Bind("ID, SongName, DateRelease, Genre, CodeQR, LinkYT, DriveLink, Image")] Song song)
		{
			if (ModelState.IsValid)
			{
				_context.Add(song);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Edit));
			}
			return View(song);

		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("ID, SongName, DateRelease, Genre, CodeQR, LinkYT, DriveLink, Image")] Song song)
		{
			if (id != song.ID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(song);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!SongExists(song.ID))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Edit));
			}
			return View(song);
		}

		[Authorize(Roles = "Editor,RegisteredUser,Critic")]
		public IActionResult Details(int id) {
			var song = _context.Song.FirstOrDefault(m => m.ID == id);
			if (song == null)
			{
				return NotFound();
			}
            string formattedDate = song.GetFormattedDateRelease();
            ViewBag.FormattedDateRelease = formattedDate;

            return View(song);
		}

		public IActionResult Song(int id) {
			var song = _context.Song.FirstOrDefault(m => m.ID == id);
			if (song == null)
			{
				return NotFound();
			}

			// Call the GetComments method to populate the Reviews property
			song.Reviews = song.GetComments("AIzaSyDGuW4OZgNlerudPj8I6uSCwyD2uUhY74I");

            string actionName = RouteData.Values["action"].ToString();
            string controllerName = RouteData.Values["controller"].ToString();

            if (actionName == "Song" && controllerName == "Song")
                song.SaveMP3();
			return View(song);
		}
		public IActionResult SaveMP3(int id)
		{
			var song = _context.Song.FirstOrDefault(m => m.ID == id);
			if (song == null)
			{
				return NotFound();
			}

			// Call the GetComments method to populate the Reviews property
			//song.SaveMP3();

			return View(song);
		}

		[Authorize(Roles = "Editor")]
        // GET: Song/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song
                .FirstOrDefaultAsync(m => m.ID == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }
       
        // POST: Song/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var song = await _context.Song.FindAsync(id);
            _context.Song.Remove(song);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    
        public IActionResult SearchResult(string search)
        {
             List<Song> songs = _context.Song.ToList();
             if (search == null)
                 ViewBag.SearchResults = songs;
             else
             {
                 string pattern = $"{Regex.Escape(search)}";
                 List<Song> searchResults = songs.Where(p => Regex.IsMatch(p.SongName, pattern, RegexOptions.IgnoreCase)).ToList();

                 ViewBag.SearchResults = searchResults;
             }
             return View(ViewBag.SearchResults);
        }
           
        private bool SongExists(int id)
        {
            return _context.Song.Any(e => e.ID == id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Song([Bind("ID,PlaylistName,Uid")] Playlist playlist)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Set the Uid property of the playlist to the user's ID
                playlist.Uid = userId;
                _context.Add(playlist);
                await _context.SaveChangesAsync();
                // return View();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID, Grade, Comment, Timestamp, SongID, Uid")] Review review)
        {
            if (ModelState.IsValid)
            {
               // Song song = _context.Song.FirstOrDefault(s => s.ID == ID);
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Song));
            }
            return View();
        }


    }
}
