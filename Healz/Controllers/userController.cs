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
            await ProfileCheck();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserProfile(UserProfileViewModel model)
        {
            var user = await GetCurrentUserAsync();
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
                Cast = model.Cast,
                ApplicationUsersID = user?.Id
            };
            repository.UpdateProfile(user.Id, n);
            return RedirectToAction("Insights");
        }

        [HttpGet]
        public async Task<IActionResult> Insights()
        {
            await ProfileCheck();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> InsightsTwo()
        {
            await ProfileCheck();
            return View();
        }
        public async Task<IActionResult> ProfileSettings()
        {
            await ProfileCheck();
            return View();
        }

        public async Task<IActionResult> JobLocations()
        {
            await ProfileCheck();
            return View();
        }

        public async Task<IActionResult> PrivateMasseges()
        {
            await ProfileCheck();
            return View();
        }

        public async Task<IActionResult> Appointments()
        {
            await ProfileCheck();
            return View();
        }
        public async Task<IActionResult> Appoinmentsetting()
        {
            await ProfileCheck();
            return View();
        }

        public async Task<IActionResult> PrivacySetting()
        {
            await ProfileCheck();
            return View();
        }
        public async Task<IActionResult> securitysettings()
        {
            await ProfileCheck();
            return View();
        }
        public async Task<IActionResult> upgradepackage()
        {
            await ProfileCheck();
            return View();
        }
        public async Task<IActionResult> invoices()
        {
            await ProfileCheck();
            return View();
        }
        public async Task<IActionResult> favoritlisting()
        {
            await ProfileCheck();
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


        //for profile get funcationality 
        private async Task<IActionResult> ProfileCheck()
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
    }
}