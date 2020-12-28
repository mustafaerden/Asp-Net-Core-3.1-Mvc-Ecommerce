using Azlan.Ecommerce.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azlan.Ecommerce.Web.Seeds
{
    public static class IdentitySeed
    {
        public static async Task SeedIdentity(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");

            if (adminRole == null)
            {
                await roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            }

            var adminUser = await userManager.FindByNameAsync("mustafaerden");

            if (adminUser == null)
            {
                AppUser user = new AppUser
                {
                    FirstName = "Mustafa",
                    LastName = "Erden",
                    Email = "mustafaerden87@gmail.com",
                    UserName = "mustafaerden"
                };

                var result = await userManager.CreateAsync(user, "123456");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }  
            }
        }
    }
}
