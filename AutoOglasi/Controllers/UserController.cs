using AutoOglasi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace AutoOglasi.Controllers
{
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;

        public UserController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser appUser = new ApplicationUser
                {
                    UserName = user.Name,
                    Email = user.Email
                };

                IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);

                if (result.Succeeded)
                {
                    // Proveri sigurnosni pečat
                    var securityStamp = await _userManager.GetSecurityStampAsync(appUser);
                    if (string.IsNullOrEmpty(securityStamp))
                    {
                        appUser.SecurityStamp = Guid.NewGuid().ToString();
                        var updateResult = await _userManager.UpdateAsync(appUser);
                        if (!updateResult.Succeeded)
                        {
                            foreach (IdentityError error in updateResult.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                            return View(user);
                        }
                    }

                    // Dodaj korisnika u rolu
                    var roleResult = await _userManager.AddToRoleAsync(appUser, "Admin");
                    if (!roleResult.Succeeded)
                    {
                        foreach (IdentityError error in roleResult.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(user);
                    }

                    ViewBag.Message = "Nalog je uspešno kreiran";
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(user);
        }
    }
}
