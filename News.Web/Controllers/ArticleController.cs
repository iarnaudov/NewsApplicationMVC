using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Models;
using News.Services.Contracts;
using News.Services.Models;
using ReflectionIT.Mvc.Paging;
using System.Linq;
using System.Threading.Tasks;

namespace News.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly NewsDbContext db;
        private readonly IHttpContextAccessor _http;
        private readonly IArticleService articles;

        public ArticleController(IArticleService articles, NewsDbContext db, IHttpContextAccessor http)
        {
            this.articles = articles;
            this.db = db;
            _http = http;
        }

        [HttpGet]
        [Route("articles")]
        [ActionName("All")]
        public IActionResult All(string ordertype, int page = 1)
        {
            TempData["sortlevel"] = TempData["sortlevel"] != null ? ordertype = (string)TempData["sortlevel"] : TempData["sortlevel"] = "name_ascending";
            TempData.Keep();

            var articlesList = this.articles.GetOrderedArticles(ordertype).ToList();
            return View(articlesList);
        }

        [HttpPost]
        [Route("articles")]
        [ActionName("All")]
        public IActionResult AllDefaul(string ordertype, int page = 1)
        {
            TempData["sortlevel"] = ordertype;
            var articlesList = this.articles.GetOrderedArticles(ordertype);
            return RedirectToAction(nameof(All));
        }


        [Route("articles/Type/{type}")]
        public IActionResult Type(string type, string ordertype)
        {
            var articles = this.articles.GetAllByType(type);
            return View("AllByType", articles);
        }


        [HttpGet]
        [Route("articles/create")]
        [Authorize(Roles = "Moderator, Administrator")]
        public IActionResult Create()
        {
            var authorName = _http.HttpContext.User.Identity.Name;

            var categoryList = this.db.Categories.Select(c => c.Name).ToList();
            ViewBag.CategoryList = categoryList;
            ViewBag.AuthorName = authorName;
            return View();
        }

        [HttpPost]
        [Route("articles/create")]
        [Authorize(Roles = "Moderator, Administrator")]
        public IActionResult Create(ArticleModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var authorName = _http.HttpContext.User.Identity.Name;

            var categoryList = this.db.Categories.Select(c => c.Name).ToList();
            ViewBag.CategoryList = categoryList;
            ViewBag.AuthorName = authorName;

            this.articles.Create(model);

            return RedirectToAction(nameof(All));
        }


        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
           var article = this.articles.FindArticle(id);

            return View(article);
        }

        [HttpGet]
        [Route("articles/edit/{id}")]
        [ActionName("Edit")]
        [Authorize(Roles = "Moderator, Administrator")]
        public IActionResult EditArticle(int id)
        {
            var articleForEdit = this.articles.Get(id);
            var tags = this.db.ArticleTags.Include(a => a.Tag).Where(t => t.ArticleId == id).Select(t => t.Tag.Name);
            string tagString= "";

            foreach (var tag in tags)
            {
                tagString = tagString + " " + tag;
            }

            var articleModel = new ArticleModel
            {
                Id = articleForEdit.Id,
                Title = articleForEdit.Title,
                Author = articleForEdit.Author.UserName,
                Category = articleForEdit.Category.Name,
                Content = articleForEdit.Content,
                Tags = tagString
            };
            var authorName = _http.HttpContext.User.Identity.Name;
            ViewBag.AuthorName = authorName;
            return View(articleModel);
        }

        [HttpPost]
        [Route("articles/edit/{id}")]
        [Authorize(Roles = "Moderator, Administrator")]
        public IActionResult Edit(int id, ArticleModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var authorName = _http.HttpContext.User.Identity.Name;
            ViewBag.AuthorName = authorName;

            var articleForEdit = this.articles.Get(id);
            var articleModel = new ArticleModel
            {
                Id = articleForEdit.Id,
                Title = articleForEdit.Title,
                Author = articleForEdit.Author.UserName,
                Category = articleForEdit.Category.Name,
                Content = articleForEdit.Content,
                Tags = model.Tags
            };

            this.articles.Edit(id, model);
            return RedirectToAction(nameof(All));
        }

        [Route("articles/delete/{id}")]
        [Authorize(Roles = "Moderator, Administrator")]
        public IActionResult Delete(int id)
        {
            this.articles.Delete(id);
            return RedirectToAction(nameof(All));
        }

    }
}