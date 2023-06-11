using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spotifive.Data;
using Spotifive.Models;
using System.Security.Claims;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.VisualStudio.Web.CodeGeneration;

namespace Spotifive.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        public AccountController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
			return View();
            
        }
        [HttpGet]
        public IActionResult Account() {

          
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId != null)
            {

                var user = _context.Users.FirstOrDefault(u => u.Id == userId);

                if (user != null)
                {
                    ViewData["ApplicationUser"] = user;
                    return View(user);
                }
            }
            return RedirectToAction("Login");
        }
     
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Account");
        }

        public IActionResult GetViewUsers(string para)
        {
            //get data
            var model = _context.Users.Where(x => x.Name.Contains(para) || x.Surname.Contains(para)).ToList();
            return PartialView("_PopUsersView", model);
        }

    }
}
