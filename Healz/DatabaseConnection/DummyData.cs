using Healz.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace Healz.DatabaseConnection
{
    public class DummyData
    {
        public static async Task Initialize(AppDbContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            string adminId1 = "";
            string adminId2 = "";

            string role1 = "Super Admin";
            string desc1 = "This is the Main Admin role";

            string role2 = "Admin";
            string desc2 = "This is the Admin role";

            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("superadmin@awsik.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "superadmin@awsik.com",
                    Email = "superadmin@awsik.com",
                    FirstName = "Muhammad",
                    LastName = "Ikhlas",
                    CNIC = "38201-2342344-1",
                    MiddelInitial = "Ahmad",
                    PhoneNumber = "03064113590"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("admin@awsik.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@awsik.com",
                    Email = "admin@awsik.com",
                    FirstName = "Muhammad",
                    LastName = "Ikhlas",
                    CNIC = "38201-2342344-1",
                    MiddelInitial = "Ahmad",
                    PhoneNumber = "03414143412"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
                adminId2 = user.Id;
            }

            //if (await userManager.FindByNameAsync("mm@mm.mm") == null)
            //{
            //    var user = new ApplicationUser
            //    {
            //        UserName = "mm@mm.mm",
            //        Email = "mm@mm.mm",
            //        FirstName = "Mike",
            //        LastName = "Myers",
            //        Street = "Yew St",
            //        City = "Vancouver",
            //        Province = "BC",
            //        PostalCode = "V3U E2Y",
            //        Country = "Canada",
            //        PhoneNumber = "6572136821"
            //    };

            //    var result = await userManager.CreateAsync(user);
            //    if (result.Succeeded)
            //    {
            //        await userManager.AddPasswordAsync(user, password);
            //        await userManager.AddToRoleAsync(user, role2);
            //    }
            //}

            //if (await userManager.FindByNameAsync("dd@dd.dd") == null)
            //{
            //    var user = new ApplicationUser
            //    {
            //        UserName = "dd@dd.dd",
            //        Email = "dd@dd.dd",
            //        FirstName = "Donald",
            //        LastName = "Duck",
            //        Street = "Well St",
            //        City = "Vancouver",
            //        Province = "BC",
            //        PostalCode = "V8U R9Y",
            //        Country = "Canada",
            //        PhoneNumber = "6041234567"
            //    };

            //    var result = await userManager.CreateAsync(user);
            //    if (result.Succeeded)
            //    {
            //        await userManager.AddPasswordAsync(user, password);
            //        await userManager.AddToRoleAsync(user, role2);
            //    }
            //}
        }

    }
}
