using Microsoft.AspNetCore.Identity;
using News.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Web
{
    public static class SeedData
    {
        public static void SeedDatabase(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUsers(UserManager<User> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                User user = new User();
                user.UserName = "admin";
                user.Email = "admin@gmail.com";

                IdentityResult result = userManager.CreateAsync(user, "admin123").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }

            if (userManager.FindByNameAsync("moderator").Result == null)
            {
                User user = new User();
                user.UserName = "moderator";
                user.Email = "moderator@gmail.com";

                IdentityResult result = userManager.CreateAsync(user, "moderator123").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Moderator").Wait();
                }
            }
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Moderator").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Moderator";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
