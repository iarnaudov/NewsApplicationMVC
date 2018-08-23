using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using News.Services.Contracts;
using News.Data;
using News.Services.Models;
using News.Models;

namespace News.Services
{
    public class ArticleService : IArticleService
    {
        private readonly NewsDbContext db;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _http;

        public ArticleService(NewsDbContext db)
        {
            this.db = db;
        }

        public ArticleService(NewsDbContext db, UserManager<User> userManager, IHttpContextAccessor http)
        {
            this.db = db;
            this._userManager = userManager;
            this._http = http;
        }

        public IOrderedQueryable<Article> GetOrderedArticles(string ordertype)
        {
            if (string.IsNullOrWhiteSpace(ordertype))
            {
                ordertype = "name_ascending";
            }


            IOrderedQueryable<Article> articlesList;

            switch (ordertype)
            {
                case "name_ascending": articlesList = this.db.Articles.Include(c => c.Author).Include(a => a.Category).AsNoTracking().OrderBy(a => a.Title); break;
                case "name_descending": articlesList = this.db.Articles.Include(c => c.Author).Include(a => a.Category).AsNoTracking().OrderByDescending(a => a.Title); break;
                case "date_latest": articlesList = this.db.Articles.Include(c => c.Author).Include(a => a.Category).AsNoTracking().OrderByDescending(a => a.TimeCreated); break;
                case "date_oldest": articlesList = this.db.Articles.Include(c => c.Author).Include(a => a.Category).AsNoTracking().OrderBy(a => a.TimeCreated); break;
                case "category_asc": articlesList = this.db.Articles.Include(c => c.Author).Include(a => a.Category).AsNoTracking().OrderBy(a => a.Category.Name); break;
                case "category_desc": articlesList = this.db.Articles.Include(c => c.Author).Include(a => a.Category).AsNoTracking().OrderByDescending(a => a.Category.Name); break;
                default: articlesList = null; break;
            }

            return articlesList;
        }


        public void Create(ArticleModel model)
        {
            var authorName = _http.HttpContext.User.Identity.Name;
            var auhorUser = this.db.Users.SingleOrDefault(u => u.UserName == authorName);

            var category = this.db.Categories.SingleOrDefault(c => c.Name == model.Category);

            var article = new Article
            {
                Author = auhorUser,
                Title = model.Title,
                Content = model.Content,
                Category = category,
                TimeCreated = DateTime.Now,
                ImageUrl = model.ImageUrl
            };

            this.db.Articles.Add(article);
            this.db.SaveChanges();

            var articleId = this.db.Articles.FirstOrDefault(a => a.Title == model.Title).Id;

            var tags = model.Tags.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var tag in tags)
            {
                this.AddTagToArticle(tag, articleId);
            }

        }

        private void AddTagToArticle(string tagName, int articleId)
        {
           var currentTag = this.db.Tags.SingleOrDefault(t => t.Name == tagName);
            int tagId;

            if (currentTag == null)
            {
                var newTag = new Tag(tagName);
                this.db.Tags.Add(newTag);
                this.db.SaveChanges();

                tagId = this.db.Tags.FirstOrDefault(t => t.Name == tagName).Id;
            }
            else
            {
                tagId = currentTag.Id;
            }

            var articleTag = new ArticleTag(articleId, tagId);
            this.db.ArticleTags.Add(articleTag);
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            var articles = this.db.Articles.ToList();
            var articleForRemove = articles.SingleOrDefault(c => c.Id == id);
            this.db.Articles.Remove(articleForRemove);
            this.db.SaveChanges();
        }

        public void Edit(int id, ArticleModel model)
        {
            var authorName = _http.HttpContext.User.Identity.Name;

            var articleForEdit = this.db.Articles.Include(a => a.Category).SingleOrDefault(a => a.Id == id);

            if (articleForEdit == null)
            {
                return;
            }

            var auhorUser = this.db.Users.SingleOrDefault(u => u.UserName == authorName);
            if (auhorUser == null)
            {
                return;
            }

            var category = this.db.Categories.SingleOrDefault(c => c.Name == model.Category);

            articleForEdit.Title = model.Title;
            articleForEdit.Content = model.Content;
            articleForEdit.Author = auhorUser;
            articleForEdit.ImageUrl = model.ImageUrl;
            this.db.SaveChanges();


            var tags = model.Tags.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var articleId = articleForEdit.Id;

            var articleTags = this.db.ArticleTags.Where(a => a.ArticleId == articleId).ToList();
            this.db.ArticleTags.RemoveRange(articleTags);
            this.db.SaveChanges();

            foreach (var tag in tags)
            {
                this.AddTagToArticle(tag, articleId);
            }

        }

        public ArticleModel FindArticle(int id)
        {
            var articlesList = this.db.Articles.Include(c => c.Author).Include(a => a.Category).ToList();
            var article = articlesList.Where(a => a.Id == id).SingleOrDefault();
            var articleTags = this.db.ArticleTags.Where(a => a.ArticleId == article.Id).Select(t => t.Tag.Name).ToList();

            var articleModel = new ArticleModel
            {
                Id = article.Id,
                Author = article.Author.UserName,
                Category = article.Category.Name,
                Content = article.Content,
                Title = article.Title,
                DateCreated = article.TimeCreated.ToShortDateString(),
                Tags = string.Join(" ", articleTags),
                ImageUrl = article.ImageUrl
            };

            return articleModel;
               
        }

        public Article Get(int id)
        {
            var articles = this.db.Articles.Include(a => a.Author).Include(a => a.Category).ToList();
            var articleForEdit = articles.SingleOrDefault(c => c.Id == id);
            return articleForEdit;
        }
    }
}
