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
        public async Task<IActionResult> Artist() { return View(await _context.Artist.ToListAsync()); }
        public IActionResult GetPartialView(string para)
        {
            //get data
            var model = _context.Artist.Where(x => x.ArtistName.Contains(para) || x.ArtistSurname.Contains(para)).ToList();
            return PartialView("_PopArtistView", model);
        }
        public IActionResult PartialViewArtist(int id)
        {
            var songs = _context.ArtistSongs.Include(x => x.Song).Where(entry => entry.ID == id).Select(entry => entry.Song);
            return PartialView("_PopView", songs);
        }
       
    }
}
