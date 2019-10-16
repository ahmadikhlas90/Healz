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
            string adminId3 = "";

            string role1 = "User";
            string role2 = "Admin";
            string role3 = "Doctor";

            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2,  DateTime.Now));
            }    
            if (await roleManager.FindByNameAsync(role3) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role3,  DateTime.Now));
            }

            if (await userManager.FindByNameAsync("user@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "user@gmail.com",
                    Email = "user@gmail.com",
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

            if (await userManager.FindByNameAsync("admin@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
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

            if (await userManager.FindByNameAsync("doctor@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "doctor@gmail.com",
                    Email = "doctor@gmail.com",
                    FirstName = "Mr.",
                    LastName = "Abdul",
                    CNIC = "38201-2342344-1",
                    MiddelInitial = "Qadeer",
                    PhoneNumber = "03234143412"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role3);
                }
                adminId3 = user.Id;
            }

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
