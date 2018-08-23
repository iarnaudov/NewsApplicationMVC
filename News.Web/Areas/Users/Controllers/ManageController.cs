using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Web.Areas.Users.Controllers
{
    [Area("Users")]
    [Authorize(Roles = "Administrator")]
    public class ManageController : Controller
    {
        private readonly IUserService userService;

        public ManageController(IUserService userService, NewsDbContext db)
        {
            this.userService = userService;
        }

        public IActionResult All()
        {
            var users = this.userService.GetAll();

            return View(users);
        }

        public IActionResult Details(string id)
        {
            var user = this.userService.GetById(id);

            return View(user);
        }

        public IActionResult Delete(string id)
        {
            this.userService.DeleteUserById(id);
            return RedirectToAction("All");
        }
    }
}
