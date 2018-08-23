using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Models;
using News.Services.Contracts;
using News.Web.Models;
using News.Web.Models.ViewModels;

namespace News.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;
        private readonly SignInManager<User> signInManager;

        public HomeController(IHomeService homeService, NewsDbContext db, SignInManager<User> signInManager)
        {
            this.homeService = homeService;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            var allArticles = this.homeService.AllArticles();
            var allCategories = this.homeService.AllCategories();

            return View(new HomeViewModel
            {
                Articles = allArticles,
                Categories = allCategories
            });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
