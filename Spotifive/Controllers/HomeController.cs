using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Spotifive.Data;
using Spotifive.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Spotifive.Controllers
{
    [Authorize(Roles = "Critic,RegisteredUser,Editor")]
    public class HomeController : Controller
    {
      
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult GetPartialView(string para)
        {
            //get data
            var model = _context.Song.Where(x => x.SongName.Contains(para)).ToList();
            return PartialView("_PopView", model);
        }
   
        public async Task<IActionResult> Home()
        {
            return View(await _context.Song.ToListAsync());
        }
    
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
