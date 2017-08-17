using cmorrisShoppingApp1.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace cmorrisShoppingApp1.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            if (!context.Users.Any(u => u.Email == "holdthesky@yahoo.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "holdthesky@yahoo.com",
                    Email = "holdthesky@yahoo.com",
                    FirstName = "Cary",
                    LastName = "Morris",
                }, "SQLCary45!");
            }
            var userId = userManager.FindByEmail("holdthesky@yahoo.com").Id;
            userManager.AddToRole(userId, "Admin");
        }
    }
}
