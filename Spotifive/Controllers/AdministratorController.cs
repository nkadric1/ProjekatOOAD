using System;
using System.Collections.Generic;
using System.Data;
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
        private readonly RoleManager<ApplicationUser> _roleManager;
        public AdministratorController(ApplicationDbContext context)
        {
            _context = context;
            //       _userManager = userManager;
            //     _roleManager = roleManager;
            //     /, UserManager<ApplicationUser> userManager, RoleManager<ApplicationUser>
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

        [HttpPost]
        public async Task<IActionResult> UpdateRoles(string id,bool isEditor, bool isCritic, bool isRegisteredUser)
        {
            /*  // Retrieve the user
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

              // Update roles based on checkbox selections
              if (isEditor)
              {
                  // User selected Editor role
                  await AddUserToRole(user, "Editor");

                  // Remove other roles if necessary
                  await RemoveUserFromRole(user, "Critic");
                  await RemoveUserFromRole(user, "RegisteredUser");
              }
              else if (isCritic)
              {
                  // User selected Critic role
                  await AddUserToRole(user, "Critic");

                  // Remove other roles if necessary
                  await RemoveUserFromRole(user, "Editor");
                  await RemoveUserFromRole(user, "RegisteredUser");
              }
              else if (isRegisteredUser)
              {
                  // User selected RegisteredUser role
                  await AddUserToRole(user, "RegisteredUser");

                  // Remove other roles if necessary
                  await RemoveUserFromRole(user, "Editor");
                  await RemoveUserFromRole(user, "Critic");
              }

              // Update the user in the database
              _context.Update(user);
              await _context.SaveChangesAsync();
              */
           /* if (ModelState.IsValid)
            {
                // THIS LINE IS IMPORTANT
                var oldUser = _userManager.FindByIdAsync(id);
              

                var oldRoleName = DB.Roles.SingleOrDefault(r => r.Id == oldRoleId).Name;

                if (oldRoleName != role)
                {
                    Manager.RemoveFromRole(user.Id, oldRoleName);
                    Manager.AddToRole(user.Id, role);
                }
                DB.Entry(user).State = EntityState.Modified;

                return RedirectToAction(MVC.User.Index());
            }*/
            // Redirect the user to a page indicating the successful role update
            return RedirectToAction("Account", "Account");
        }

        private async Task AddUserToRole(ApplicationUser user, string roleName)
        {
            if (!await _userManager.IsInRoleAsync(user, roleName))
            {
                var role = _roleManager.FindByNameAsync(roleName).Result;
                if (role != null)
                {
                    await _userManager.AddToRoleAsync(user, role.Name);
                }
            }
        }

        private async Task RemoveUserFromRole(ApplicationUser user, string roleName)
        {
            if (await _userManager.IsInRoleAsync(user, roleName))
            {
                await _userManager.RemoveFromRoleAsync(user, roleName);
            }
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

    // GET: Administrator/Delete/5
    public async Task<IActionResult> Delete(string id)
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
            return RedirectToAction("Account", "Account");
        }
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

        // pokusaj za izmjenu aspnetroles metoda
        [HttpPost]
        public async Task<IActionResult> UpdateRole(string userId, bool isAdmin)
        {
            // Retrieve the user
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                // Handle user not found
                return NotFound();
            }

            // Check if the user is in the "Admin" role
            var isInRole = await _userManager.IsInRoleAsync(user, "Admin");

            if (isAdmin && !isInRole)
            {
                // If the checkbox is checked and the user is not in the role, add the role
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            else if (!isAdmin && isInRole)
            {
                // If the checkbox is unchecked and the user is in the role, remove the role
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            }

            // Redirect the user to a page indicating the successful role update
            return RedirectToAction("Index", "Home");
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
    