using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Healz.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Healz.Entities;
using Microsoft.AspNetCore.Authorization;
using Healz.Models.UserProfile;
using Microsoft.AspNetCore.Hosting.Internal;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Healz.Entities.BasicInfo;
using Healz.DatabaseConnection;
using Healz.Handler;
using Healz.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Healz.Controllers
{
    [Authorize(Policy = "UserRolePolicy")]
    public class UserController : Controller
    {
        private Task<ApplicationUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);

        private readonly UserManager<ApplicationUser> userManager;
        private IUserClaimsPrincipalFactory<ApplicationUser> claimPrincipalFactory;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly AppDbContext db;
        private readonly IPateintInfoRepository repository;

        public UserController(UserManager<ApplicationUser> userManager,
            IUserClaimsPrincipalFactory<ApplicationUser> claimsPrincipalFactory,
            IHostingEnvironment hostingEnvironment,
            AppDbContext db,
            IPateintInfoRepository repository)
        {
            this.userManager = userManager;
            this.claimPrincipalFactory = claimsPrincipalFactory;
            this.hostingEnvironment = hostingEnvironment;
            this.db = db;
            this.repository = repository;
        }


        //set User Profile Data
        [HttpGet]
        public async Task<IActionResult> UserProfile()
        {
            var user = await GetCurrentUserAsync();
            UserProfileViewModel patientInfo = new UserProfileViewModel();
            string v1 = patientInfo.ApplicationUsersID = user.Id;

            PatientInfo found = null;
            found = (from p in db.PatientInfo
                     where p.ApplicationUsersID == v1
                     select p).FirstOrDefault();
            ViewBag.bd = found;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserProfile(UserProfileViewModel model)
        {
            var user = await GetCurrentUserAsync();
            //success
            if (!ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.photo != null)
                {
                    string uploadsfolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    //for unique id 
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.photo.FileName;
                    string filepath = Path.Combine(uploadsfolder, uniqueFileName);
                    model.photo.CopyTo(new FileStream(filepath, FileMode.Create));
                }
                PatientInfo n = new PatientInfo
                {
                    ZipCode = model.ZipCode,
                    Designation = model.Designation,
                    MailingAddress = model.MailingAddress,
                    MinitelStatus = model.MinitelStatus,
                    Occupation = model.Occupation,
                    MotherName = model.MotherName,
                    PhysicalAddress = model.PhysicalAddress,
                    ReligionName = model.ReligionName,
                    SpouseName = model.SpouseName,
                    SufferingFrom = model.SufferingFrom,
                    ImageUrl = uniqueFileName,
                    Cast=model.Cast,
                    ApplicationUsersID=user?.Id
                };

                repository.UpdateProfile(user.Id, n);
                return RedirectToAction("Insights");

                //db.Add(n);
                //db.SaveChanges();
                //return RedirectToAction("Index", "Home");
            }
            return View();
        }


        public IActionResult Insights()
        {
            return View();
        }
        public IActionResult InsightsTwo()
        {
            return View();
        }
        public IActionResult ProfileSettings()
        {
            return View();
        }

        public IActionResult JobLocations()
        {
            return View();
        }

        public IActionResult PrivateMasseges()
        {
            return View();
        }

        public IActionResult Appointments()
        {
            return View();
        }
        public IActionResult Appoinmentsetting()
        {
            return View();
        }

        public IActionResult PrivacySetting()
        {
            return View();
        }
        public IActionResult securitysettings()
        {
            return View();
        }
        public IActionResult upgradepackage()
        {
            return View();
        }
        public IActionResult invoices()
        {
            return View();
        }
        public IActionResult favoritlisting()
        {
            return View();
        }


        [HttpGet]
        public IActionResult ExternalLogin(string provider)
        {
            var properties = new AuthenticationProperties
            {
                RedirectUri = Url.Action("ExternalLoginCallback"),
                Items = {{ "Scheme", provider }}
            };
            return Challenge(properties, provider);
        }
        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback()
        {
            var result = await HttpContext.AuthenticateAsync(IdentityConstants.ExternalScheme);
            var externalUserId = result.Principal.FindFirstValue("sub")
                ?? result.Principal.FindFirstValue(ClaimTypes.NameIdentifier)
                ?? throw new Exception("Cannot find External user id");
            var provider = result.Properties.Items["Scheme"];
            var user = await userManager.FindByLoginAsync(provider, externalUserId);
            if (user == null)
            {
                var email = result.Principal.FindFirstValue("email")
                    ?? result.Principal.FindFirstValue(ClaimTypes.Email);
                if (email != null)
                {
                    user = await userManager.FindByEmailAsync(email);
                    if (user == null)
                    {
                        user = new ApplicationUser { UserName = email, Email = email };
                        await userManager.CreateAsync(user);

                    }
                    await userManager.AddLoginAsync(user, 
                        new UserLoginInfo(provider, externalUserId, provider));
                }
            }
            if (user == null) return View("Error");
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            var ClaimPrinciple = await claimPrincipalFactory.CreateAsync(user);
            await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, ClaimPrinciple);
            return RedirectToAction("Insights");
        }




        
    }
}