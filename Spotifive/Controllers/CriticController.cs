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
    public class CriticController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CriticController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Critic
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Critic.Include(c => c.Account);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Critic/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var critic = await _context.Critic
                .Include(c => c.Account)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (critic == null)
            {
                return NotFound();
            }

            return View(critic);
        }

        // GET: Critic/Create
        public IActionResult Create()
        {
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID");
            return View();
        }

        // POST: Critic/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Surname,DateOfBirth,Gender,AccountID")] Critic critic)
        {
            if (ModelState.IsValid)
            {
                _context.Add(critic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", critic.AccountID);
            return View(critic);
        }

        // GET: Critic/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var critic = await _context.Critic.FindAsync(id);
            if (critic == null)
            {
                return NotFound();
            }
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", critic.AccountID);
            return View(critic);
        }

        // POST: Critic/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Surname,DateOfBirth,Gender,AccountID")] Critic critic)
        {
            if (id != critic.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(critic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CriticExists(critic.ID))
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
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", critic.AccountID);
            return View(critic);
        }

        // GET: Critic/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var critic = await _context.Critic
                .Include(c => c.Account)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (critic == null)
            {
                return NotFound();
            }

            return View(critic);
        }

        // POST: Critic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var critic = await _context.Critic.FindAsync(id);
            _context.Critic.Remove(critic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CriticExists(int id)
        {
            return _context.Critic.Any(e => e.ID == id);
        }
    }
}
