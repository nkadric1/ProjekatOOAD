using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp.Dom;
using Google.Apis.YouTube.v3.Data;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Spotifive.Data;
using Spotifive.Models;
using static Humanizer.In;

namespace Spotifive.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        public AdministratorController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            _context = context;
              _userManager = userManager;
            _roleManager = roleManager;
        }
        

        public IActionResult Administrator(string id) {

            var per = _context.Users.FirstOrDefault(m => m.Id == id);
            if (per == null)
            {
                return NotFound();
            }
            IEnumerable<IdentityRole> roles = _roleManager.Roles.ToList();
            ViewBag.Roles = new SelectList(roles.ToList(), "Id", "Name");
            return View(per);
        }


        [HttpPost]
        public IActionResult Update(string id, ApplicationUser updatedUser)
        {
            // Retrieve the existing user from the database using the id
            var user = _context.Users.Find(id);

            if (user == null)
            {
                // Handle the case where the user does not exist
                // ...
            }

            // Update the properties of the existing user with the new values
            user.Name = updatedUser.Name;
            user.Surname = updatedUser.Surname;
            user.DateOfBirth = updatedUser.DateOfBirth;
            user.Gender = updatedUser.Gender;
            user.Role = updatedUser.Role;
            // Update other properties

            // Save the changes to the database
            _context.SaveChanges();

            return Redirect(Request.Headers["Referer"].ToString());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Name,Surname,DateOfBirth,Email,Gender,Role")] ApplicationUser applicationUser)
        {
            if (id != applicationUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicationUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Edit));
            }
            return RedirectToAction("Account", "Account");
        }

        [Authorize(Roles = "Editor")]
        public IActionResult Edit(string id)
        {
            var user = _context.Users.FirstOrDefault(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return RedirectToAction("Account", "Account");

        }
        //GET
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
		//POST
		[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Account", "Account");
        }

        
        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}
