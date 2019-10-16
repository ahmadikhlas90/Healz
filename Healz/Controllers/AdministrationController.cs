﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Healz.Entities;
using Healz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Healz.Controllers
{  //[Authorize(Policy ="AdminRolePolicy")]
   //[Authorize(Policy = "SuperAdminPolicy")]
   //[Authorize(Policy = "EditRolePolicy")]
    [Authorize(Roles = "Admin")]
    //[Authorize(Roles ="Admin,User")]  <=both rules members allow both 
    //[Authorize(Roles ="User")]   <=Single Rule Member allow only single if we write both then those access who have member of both
    public class AdministrationController : Controller
    {
      
            private readonly RoleManager<ApplicationRole> roleManager;
            private readonly UserManager<ApplicationUser> userManager;
            private readonly ILogger<AdministrationController> logger;

            public AdministrationController(RoleManager<ApplicationRole> roleManager,
                UserManager<ApplicationUser> userManager,
                ILogger<AdministrationController> logger)
            {
                this.roleManager = roleManager;
                this.userManager = userManager;
                this.logger = logger;
            }
            [HttpGet]
            [AllowAnonymous]
            public IActionResult AccessDenied()
            {
                return View();
            }

            [HttpGet]
            public IActionResult CreateRole()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
            {
                if (ModelState.IsValid)
                {
                // We just need to specify a unique role name to create a new role
                ApplicationRole identityRole = new ApplicationRole
                {
                        Name = model.RoleName
                    };

                    // Saves the role in the underlying AspNetRoles table
                    IdentityResult result = await roleManager.CreateAsync(identityRole);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Administration", "ListRoles");
                    }

                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

                return View(model);
            }

            [HttpGet]
            public IActionResult ListRoles()
            {
                var roles = roleManager.Roles;
                return View(roles);
            }


            [HttpGet]
        //[Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> EditRole(string id)
            {
                // Find the role by Role ID
                var role = await roleManager.FindByIdAsync(id);

                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                    return View("Error");
                }

                var model = new EditRoleViewModel
                {
                    Id = role.Id,
                    RoleName = role.Name
                };

                // Retrieve all the Users
                foreach (var user in userManager.Users)
                {
                    // If the user is in this role, add the username to
                    // Users property of EditRoleViewModel. This model
                    // object is then passed to the view for display
                    if (await userManager.IsInRoleAsync(user, role.Name))
                    {
                        model.Users.Add(user.UserName);
                    }
                }

                return View(model);
            }

            // This action responds to HttpPost and receives EditRoleViewModel
            [HttpPost]
            //[Authorize(Policy = "EditRolePolicy")]
            public async Task<IActionResult> EditRole(EditRoleViewModel model)
            {
                var role = await roleManager.FindByIdAsync(model.Id);

                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    role.Name = model.RoleName;

                    // Update the Role using UpdateAsync
                    var result = await roleManager.UpdateAsync(role);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("ListRoles");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View(model);
                }
            }

            [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
            {
                ViewBag.roleId = roleId;
                var role = await roleManager.FindByIdAsync(roleId);
                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                    return View("NotFound");
                }
                var model = new List<UserRoleViewModel>();
                foreach (var user in userManager.Users)
                {
                    var userRoleViewModel = new UserRoleViewModel
                    {
                        UserId = user.Id,
                        UserName = user.UserName
                    };
                    if (await userManager.IsInRoleAsync(user, role.Name))
                    {
                        userRoleViewModel.IsSelected = true;
                    }
                    else
                    {
                        userRoleViewModel.IsSelected = false;
                    }
                    model.Add(userRoleViewModel);
                }
                return View(model);
            }

            [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
            {
                var role = await roleManager.FindByIdAsync(roleId);

                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                    return View("NotFound");
                }

                for (int i = 0; i < model.Count; i++)
                {
                    var user = await userManager.FindByIdAsync(model[i].UserId);

                    IdentityResult result = null;

                    if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                    {
                        result = await userManager.AddToRoleAsync(user, role.Name);
                    }
                    else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                    {
                        result = await userManager.RemoveFromRoleAsync(user, role.Name);
                    }
                    else
                    {
                        continue;
                    }

                    if (result.Succeeded)
                    {
                        if (i < (model.Count - 1))
                            continue;
                        else
                            return RedirectToAction("EditRole", new { Id = roleId });
                    }
                }

                return RedirectToAction("EditRole", new { Id = roleId });
            }

            [HttpGet]
            public IActionResult ListUsers()
            {
                var users = userManager.Users;
                return View(users);
            }

            [HttpGet]
            public async Task<IActionResult> EditUser(string id)
            {
                var user = await userManager.FindByIdAsync(id);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                    return View("NotFound");
                }

                // GetClaimsAsync retunrs the list of user Claims
                var userClaims = await userManager.GetClaimsAsync(user);
                // GetRolesAsync returns the list of user Roles
                var userRoles = await userManager.GetRolesAsync(user);

                var model = new EditUserViewModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    UserName = user.UserName,
                    FirsName=user.FirstName,
                    LastName=user.LastName,
                    //Claims = userClaims.Select(c => c.Type + " : " + c.Value).ToList(),
                    Roles = userRoles
                };

                return View(model);
            }

            [HttpPost]
            public async Task<IActionResult> EditUser(EditUserViewModel model)
            {
                var user = await userManager.FindByIdAsync(model.Id);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    user.Email = model.Email;
                    user.UserName = model.UserName;
                user.FirstName = model.FirsName;
                user.LastName = model.LastName;
                    //user.City = model.City;

                    var result = await userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("ListUsers");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View(model);
                }
            }

            [HttpPost]
            public async Task<IActionResult> DeleteUser(string id)
            {
                var user = await userManager.FindByIdAsync(id);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    var result = await userManager.DeleteAsync(user);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("ListUsers");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View("ListUsers");
                }
            }




            [HttpPost]
            //[Authorize(Policy = "DeleteRolePolicy")]
            public async Task<IActionResult> DeleteRole(string id)
            {
                var role = await roleManager.FindByIdAsync(id);

                if (role == null)
                {
                    ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    // Wrap the code in a try/catch block
                    try
                    {
                        //throw new Exception("Test Exception");
                        var result = await roleManager.DeleteAsync(role);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("ListRoles");
                        }
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View("ListRoles");
                    }
                    // If the exception is DbUpdateException, we know we are not able to
                    // delete the role as there are users in the role being deleted
                    catch (DbUpdateException ex)
                    {
                        //Log the exception to a file. We discussed logging to a file
                        // using Nlog in Part 63 of ASP.NET Core tutorial
                        logger.LogError($"Exception Occured : {ex}");
                        // Pass the ErrorTitle and ErrorMessage that you want to show to
                        // the user using ViewBag. The Error view retrieves this data
                        // from the ViewBag and displays to the user.
                        ViewBag.ErrorTitle = $"{role.Name} role is in use";
                        ViewBag.ErrorMessage = $"{role.Name} role cannot be deleted as there are users in this role. If you want to delete this role, please remove the users from the role and then try to delete";
                        return View("Error");
                    }
                }
            }

            [HttpGet]
            //[Authorize(Policy = "EditRolePolicy")]
            public async Task<IActionResult> ManageUserRoles(string userId)
            {
                ViewBag.userId = userId;

                var user = await userManager.FindByIdAsync(userId);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                    return View("NotFound");
                }

                var model = new List<UserRolesViewModel>();

                foreach (var role in roleManager.Roles)
                {
                    var userRolesViewModel = new UserRolesViewModel
                    {
                        RoleId = role.Id,
                        RoleName = role.Name
                    };

                    if (await userManager.IsInRoleAsync(user, role.Name))
                    {
                        userRolesViewModel.IsSelected = true;
                    }
                    else
                    {
                        userRolesViewModel.IsSelected = false;
                    }

                    model.Add(userRolesViewModel);
                }

                return View(model);
            }
            [HttpPost]
            //[Authorize(Policy = "EditRolePolicy")]
            public async Task<IActionResult> ManageUserRoles(List<UserRolesViewModel> model, string userId)
            {
                var user = await userManager.FindByIdAsync(userId);

                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                    return View("NotFound");
                }

                var roles = await userManager.GetRolesAsync(user);
                var result = await userManager.RemoveFromRolesAsync(user, roles);

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Cannot remove user existing roles");
                    return View(model);
                }

                result = await userManager.AddToRolesAsync(user,
                    model.Where(x => x.IsSelected).Select(y => y.RoleName));

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Cannot add selected roles to user");
                    return View(model);
                }

                return RedirectToAction("EditUser", new { Id = userId });
            }


           
        }
}