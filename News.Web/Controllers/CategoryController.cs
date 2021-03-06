﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using News.Services.Contracts;
using News.Web.Models.ViewModels;
using News.Services.Models;
using News.Models;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Authorization;
using AutoMapper.QueryableExtensions;

namespace News.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categories;

        public CategoryController(ICategoryService categories)
        {
            this.categories = categories;
        }

        [HttpGet]
        [Route("Category")]
        [ActionName("All")]
        public IActionResult All(string ordertype, int page = 1)
        {
            TempData["orderLevel"] = TempData["orderLevel"] != null ? ordertype = (string)TempData["orderLevel"] : TempData["orderLevel"] = "name_ascending";
            TempData.Keep();

            var categoryList = this.categories.GetOrderedCategories(ordertype);
            return View(categoryList);
        }

        [HttpPost]
        [Route("Category")]
        [ActionName("All")]
        public IActionResult AllDefaul(string ordertype, int page = 1)
        {
            TempData["orderLevel"] = ordertype;
            var categoryList = this.categories.GetOrderedCategories(ordertype);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        [Route("category/create")]
        [Authorize(Roles = "Moderator, Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("category/create")]
        [Authorize(Roles = "Moderator, Administrator")]
        public IActionResult Create(CategoryModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.categories.Create(model.Name);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        [Route("category/edit/{id}")]
        [ActionName("Edit")]
        [Authorize(Roles = "Moderator, Administrator")]
        public IActionResult EditCategory(int id)
        {
            var categoryForEdit = this.categories.Get(id);
            return View(categoryForEdit);
        }

        [HttpPost]
        [Route("category/edit/{id}")]
        [Authorize(Roles = "Moderator, Administrator")]
        public IActionResult Edit(int id, CategoryModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.categories.Edit(id, model);
            return RedirectToAction(nameof(All));
        }

        [Route("category/delete/{id}")]
        [Authorize(Roles = "Moderator, Administrator")]
        public IActionResult Delete(int id)
        {
            this.categories.Delete(id);
            return RedirectToAction(nameof(All));
        }


    }
}