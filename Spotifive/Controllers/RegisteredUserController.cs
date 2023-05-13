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
    public class RegisteredUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegisteredUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RegisteredUser
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RegisteredUser.Include(r => r.Account).Include(r => r.Song);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RegisteredUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registeredUser = await _context.RegisteredUser
                .Include(r => r.Account)
                .Include(r => r.Song)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (registeredUser == null)
            {
                return NotFound();
            }

            return View(registeredUser);
        }

        // GET: RegisteredUser/Create
        public IActionResult Create()
        {
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID");
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID");
            return View();
        }

        // POST: RegisteredUser/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SongID,ID,Name,Surname,DateOfBirth,Gender,AccountID")] RegisteredUser registeredUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registeredUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", registeredUser.AccountID);
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID", registeredUser.SongID);
            return View(registeredUser);
        }

        // GET: RegisteredUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registeredUser = await _context.RegisteredUser.FindAsync(id);
            if (registeredUser == null)
            {
                return NotFound();
            }
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", registeredUser.AccountID);
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID", registeredUser.SongID);
            return View(registeredUser);
        }

        // POST: RegisteredUser/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SongID,ID,Name,Surname,DateOfBirth,Gender,AccountID")] RegisteredUser registeredUser)
        {
            if (id != registeredUser.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registeredUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegisteredUserExists(registeredUser.ID))
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
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", registeredUser.AccountID);
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID", registeredUser.SongID);
            return View(registeredUser);
        }

        // GET: RegisteredUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registeredUser = await _context.RegisteredUser
                .Include(r => r.Account)
                .Include(r => r.Song)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (registeredUser == null)
            {
                return NotFound();
            }

            return View(registeredUser);
        }

        // POST: RegisteredUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registeredUser = await _context.RegisteredUser.FindAsync(id);
            _context.RegisteredUser.Remove(registeredUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegisteredUserExists(int id)
        {
            return _context.RegisteredUser.Any(e => e.ID == id);
        }
    }
}
