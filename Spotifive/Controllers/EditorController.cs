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
    public class EditorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EditorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Editor
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Editor.Include(e => e.Account).Include(e => e.Song);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Editor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editor = await _context.Editor
                .Include(e => e.Account)
                .Include(e => e.Song)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (editor == null)
            {
                return NotFound();
            }

            return View(editor);
        }

        // GET: Editor/Create
        public IActionResult Create()
        {
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID");
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID");
            return View();
        }

        // POST: Editor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SongID,ID,Name,Surname,DateOfBirth,Gender,AccountID")] Editor editor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", editor.AccountID);
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID", editor.SongID);
            return View(editor);
        }

        // GET: Editor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editor = await _context.Editor.FindAsync(id);
            if (editor == null)
            {
                return NotFound();
            }
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", editor.AccountID);
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID", editor.SongID);
            return View(editor);
        }

        // POST: Editor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SongID,ID,Name,Surname,DateOfBirth,Gender,AccountID")] Editor editor)
        {
            if (id != editor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditorExists(editor.ID))
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
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", editor.AccountID);
            ViewData["SongID"] = new SelectList(_context.Song, "ID", "ID", editor.SongID);
            return View(editor);
        }

        // GET: Editor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editor = await _context.Editor
                .Include(e => e.Account)
                .Include(e => e.Song)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (editor == null)
            {
                return NotFound();
            }

            return View(editor);
        }

        // POST: Editor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var editor = await _context.Editor.FindAsync(id);
            _context.Editor.Remove(editor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditorExists(int id)
        {
            return _context.Editor.Any(e => e.ID == id);
        }
    }
}
