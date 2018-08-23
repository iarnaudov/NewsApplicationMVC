using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using News.Services.Contracts;
using News.Data;
using News.Services.Models;
using News.Models;
using AutoMapper.QueryableExtensions;

namespace News.Services
{
    public class HomeService : IHomeService
    {
        private readonly NewsDbContext db;

        public HomeService(NewsDbContext db)
        {
            this.db = db;
        }

        public List<ArticleModel> AllArticles()
        {
            var articlesList = this.db.Articles
                .Include(c => c.Author)
                .Include(a => a.Category)
                .ProjectTo<ArticleModel>()
                .ToList();

            //var articlesModel = articlesList.Select(c => new ArticleModel
            //{
            //    Id = c.Id,
            //    Content = c.Content,
            //    Title = c.Title,
            //    Category = c.Category.Name,
            //    Author = c.Author.UserName,
            //}).ToList();

            return articlesList;
        }

        public List<Category> AllCategories()
        {
            var categoriesList = this.db.Categories.Include(c => c.Articles).ToList();

            return categoriesList;
        }
    }
}
