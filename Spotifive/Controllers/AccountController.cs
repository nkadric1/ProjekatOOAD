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
			//await _context.Account.ToListAsync()
			return View();
            
        }
        [HttpGet]
        [Authorize(Roles = "Critic,RegisteredUser,Editor,Administrator")]
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


        // GET: Account/Edit/5
        /*  public async Task<IActionResult> Edit(int? id)
          {
              if (id == null)
              {
                  return NotFound();
              }

              var account = await _context.Account.FindAsync(id);
              if (account == null)
              {
                  return NotFound();
              }
              return View(account);
          }

          // POST: Account/Edit/5
          // To protect from overposting attacks, enable the specific properties you want to bind to.
          // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
          [HttpPost]
          [ValidateAntiForgeryToken]
          public async Task<IActionResult> Edit(int id, [Bind("ID,Username,Password,Email")] Account account)
          {
              if (id != account.ID)
              {
                  return NotFound();
              }

              if (ModelState.IsValid)
              {
                  try
                  {
                      _context.Update(account);
                      await _context.SaveChangesAsync();
                  }
                  catch (DbUpdateConcurrencyException)
                  {
                      if (!AccountExists(account.ID))
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
              return View(account);
          }
        */
        // GET: Account/Delete/5
        /* public async Task<IActionResult> Delete(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var account = await _context.Account
                 .FirstOrDefaultAsync(m => m.ID == id);
             if (account == null)
             {
                 return NotFound();
             }

             return View(account);
         }

         // POST: Account/Delete/5
         [HttpPost, ActionName("Delete")]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> DeleteConfirmed(int id)
         {
             var account = await _context.Account.FindAsync(id);
             _context.Account.Remove(account);
             await _context.SaveChangesAsync();
             return RedirectToAction(nameof(Index));
         }

         private bool AccountExists(int id)
         {
             return _context.Account.Any(e => e.ID == id);
         }*/
    }
}
