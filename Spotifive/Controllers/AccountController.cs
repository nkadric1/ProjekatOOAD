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
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Account.ToListAsync());
        }


        // GET: Account/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Username,Password,Email")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        //when user want to log in p+++
        public IActionResult LogIn(String username, String password) { return View(); }
        // check this method and create??????
        public IActionResult SignIn(bool type, String username, String password, String email, [Bind("ID,Name,Sirname,DateOfBirth,Gender,AccountID")] Person person)
        {
            //Create(person.AccountID);
            //how to add account to user that is in process of making new profile
            return View();
        }
        public IActionResult OnForgotClick() { return View(); }
        public IActionResult ResetPassword() { return View(); }
        public IActionResult GetOnHomeScreen() { return View(); }

        public IActionResult SignOut() { return View(); }

        private bool AccountExists(int id)
        {
            return _context.Account.Any(e => e.ID == id);
        }
    }
}
