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

namespace Spotifive.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        public AdministratorController(ApplicationDbContext context)
        {
            _context = context;
        }

      /*  // GET: Administrator
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Administrator.Include(a => a.Account);
            return View(await applicationDbContext.ToListAsync());
        }*/

        public IActionResult Administrator(string id) {

            var per = _context.Users.FirstOrDefault(m => m.Id == id);
            if (per == null)
            {
                return NotFound();
            }

           
            return View(per);
        }
        public IActionResult GetViewUsers(string para)
        {
            //get data
            var model = _context.Users.Where(x => x.Name.Contains(para) ||  x.Surname.Contains(para)).ToList();
            return PartialView("_PopUsersView", model);
        }
       // GET: Administrator/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
     
        // GET: Administrator/Create
      /* public IActionResult Create()
        {
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID");
            return View();
        }

        // POST: Administrator/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Surname,DateOfBirth,Gender,AccountID")] Administrator administrator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(administrator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", administrator.AccountID);
            return View(administrator);
        }

        // GET: Administrator/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrator = await _context.Administrator.FindAsync(id);
            if (administrator == null)
            {
                return NotFound();
            }
            ViewData["AccountID"] = new SelectList(_context.Account, "ID", "ID", administrator.AccountID);
            return View(administrator);
        }
      */
        // POST: Administrator/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
  /*      [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Surname,DateOfBirth,Gender,AccountID")] Administrator administrator)
        {
            if (id != administrator.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(administrator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdministratorExists(administrator.ID))
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
            
            return View(administrator);
        }
  */
     
        // POST: Administrator/Delete/5
     [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Account", "Account");
        }
        public async Task<IActionResult> Update(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
                return View(user);
            else
                return RedirectToAction("Account", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> Update(string id, string email)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(email))
                    user.Email = email;
                else
                    ModelState.AddModelError("", "Email cannot be empty");

               
                if (!string.IsNullOrEmpty(email))
                {
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Account","Account");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View(user);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}

     /*   private bool AdministratorExists(int id)
        {
            return _context.Administrator.Any(e => e.ID == id);
        }*/
    