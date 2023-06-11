using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
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
      

        // POST: Song/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Editor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("ID,SongName,DateRelease,Genre,CodeQR,LinkYT")] Song song)
        {
            if (ModelState.IsValid)
            {
                _context.Add(song);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Song));
            }
            return View(song);
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("ID,SongName,DateRelease,Genre,CodeQR,LinkYT")] Song song)
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

		// public IActionResult Edit() { return View(); }
		public IActionResult Edit(int id) {
			var song = _context.Song.FirstOrDefault(m => m.ID == id);
			if (song == null)
			{
				return NotFound();
			}
			return View(song);
			
        }

		//delete
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
			//return RedirectToAction(nameof(Edit));
			return RedirectToAction("Home", "Home");
			//return View();
		}
		public IActionResult Create() { return View(); }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("ID, SongName, DateRelease, Genre, CodeQR, LinkYT, DriveLink, Image")] Song song)
		{
			if (ModelState.IsValid)
			{
				_context.Add(song);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Create));
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


			/*var artist = song.Artist;
			if (artist == null)
			{
				return NotFound();
			}*/

			//artist.ArtistName

			return View(song);
		}

		public IActionResult Song(int id) {
			var song = _context.Song.FirstOrDefault(s => s.ID == id);
			//var song = _context.Song.Include(s => s.Reviews).FirstOrDefault(s => s.ID == id);
			if (song == null)
			{
				return NotFound();
			}

			string actionName = RouteData.Values["action"].ToString();
			string controllerName = RouteData.Values["controller"].ToString();

			if (actionName == "Song" && controllerName == "Song")
			{
				song.SaveMP3();

			}
			//var reviews = _context.Review.ToList();


			var playlists = _context.Playlist.ToList();

			// Assign the playlists to the ViewBag
			ViewBag.Playlists = playlists;
			// Call the GetComments method to populate the Reviews property
			song.Reviews = song.GetComments("AIzaSyDGuW4OZgNlerudPj8I6uSCwyD2uUhY74I");

			

			return View(song);
		}
		
		/*[HttpPost]
		public IActionResult AddSongToPlaylist([FromBody] int songId, [FromBody] int playlistId)
		{
			var song = _context.Song.FirstOrDefault(s => s.ID == songId);
			var playlist = _context.Playlist.FirstOrDefault(p => p.ID == playlistId);

			if (song != null && playlist != null)
			{
				var playlistSong = new PlaylistSongs
				{
					PlaylistID = playlist.ID,
					SongID = song.ID
				};

				_context.PlaylistSongs.Add(playlistSong);
				_context.SaveChanges();
			}

			return RedirectToAction("Song", "Song");
		}*/
		public IActionResult SaveMP3(int id)
		{
			var song = _context.Song.FirstOrDefault(m => m.ID == id);
			if (song == null)
			{
				return NotFound();
			}

			// Call the GetComments method to populate the Reviews property
		song.SaveMP3();

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
			return RedirectToAction("Home", "Home");
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
		public async Task<IActionResult> AddToPlaylist(Song song, int playlistSelection)
		{
			if (ModelState.IsValid)
			{
				if (playlistSelection != 0)
				{

					var existingEntry = await _context.PlaylistSongs
			  .FirstOrDefaultAsync(ps => ps.SongID == song.ID && ps.PlaylistID == playlistSelection);

					if (existingEntry != null)
					{
						// Song already exists in the playlist, handle accordingly (e.g., display an error message)
						ModelState.AddModelError(string.Empty, "The song is already in the playlist.");
						return Redirect(Request.Headers["Referer"].ToString());
					}

					// Add the song to the PlaylistSongs table
					var playlistSong = new PlaylistSongs
					{
						SongID = song.ID,
						PlaylistID = playlistSelection
					};

					_context.Add(playlistSong);
					await _context.SaveChangesAsync();

					//return RedirectToAction("Song", "Song");
					//return RedirectToAction(nameof(Song));
					//return View();
					//return Redirect(Request.UrlReferrer.ToString());
					return Redirect(Request.Headers["Referer"].ToString());
				}
				else
				{
					ModelState.AddModelError(string.Empty, "Please select a playlist");
				}
			}

			return View(song);
			//return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddReview(int id, Review review)
		{
			if (ModelState.IsValid)
			{
				var song = _context.Song.FirstOrDefault(m => m.ID == id);
				song.Review = new Review();
				// Set the foreign key values
				song.Review.SongID = song.ID;
				song.Review.Uid = User.FindFirstValue(ClaimTypes.NameIdentifier);
				song.Review.TimeStamp = DateTime.Now.ToString();
				song.Review.Comment = review.Comment;
				song.Review.Grade = review.Grade;


				// Save the review to the database
				_context.Review.Add(song.Review);
				await _context.SaveChangesAsync();

				// Redirect back to the Song view
				return Redirect(Request.Headers["Referer"].ToString());
			}

			// If model is not valid, return to the same view with validation errors
			return Redirect(Request.Headers["Referer"].ToString());
		}

	}
}

