using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Spotifive.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Spotifive.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult GetProfile() { return View(); }
        public IActionResult OnArtistClick() { return View(); }
        public IActionResult OnPlaylistClick() { return View(); }
        public IActionResult SearchSong() { return View(); }
        public IActionResult OnSongClick() { return View(); }

    }
}
