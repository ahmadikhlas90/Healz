﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Healz.DatabaseConnection;
using Healz.Entities;
using Healz.Entities.BasicInfo;
using Healz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Healz.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly AppDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;


        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, 
            RoleManager<ApplicationRole>  roleManager,
            AppDbContext db
         )
        {
            this.roleManager = roleManager;
            this.db = db;
            this.userManager = userManager;
            this.signInManager = signInManager;
       
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {

            List<SelectListItem> items = new List<SelectListItem> { new SelectListItem { Value = "0", Text = "- Select Country -" } };
            foreach (var role in roleManager.Roles)
            {
                items.Add(new SelectListItem() { Value = role.Name, Text = role.Name });
            }
            ViewBag.item = items;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
              
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                };
                var result = await userManager.CreateAsync(user, model.Password);
               
                if (result.Succeeded)
                {
                   result = await userManager.AddToRoleAsync(user, model.RoleName);
                    if ( model.RoleName == "Admin" && user.FirstName=="AWSIK")
                    {

                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Insights", "User");
                    }
                    if ( model.RoleName == "Doctor")
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("invoices", "User");
                    }
                    if ( model.RoleName == "User")
                    {
                        var use = new PatientInfo
                        {
                            ApplicationUsersID = user.Id,
                            MailingAddress=model.PatientInfo.MailingAddress
                            
                        };
                        db.Add(use);
                        db.SaveChanges();
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("UserProfile", "User");
                    }
                    else {
                        return RedirectToAction("Register", "Account");
                    }
                    //else {
                    //    await signInManager.SignInAsync(user, isPersistent: false);
                    //    return RedirectToAction("Index", "Home");
                    //}
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }
        //[HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [HttpPost]
        //[AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email,
                    model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("index", "home");
                    }
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }

        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use.");
            }
        }

        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }
    }
}