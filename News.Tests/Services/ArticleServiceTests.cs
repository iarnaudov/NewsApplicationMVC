using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using News.Data;
using Microsoft.EntityFrameworkCore;
using News.Services;
using News.Models;
using System.Linq;

namespace News.Tests.Services
{ 
    [TestFixture]
    public class ArticleServiceTests
    {
        private NewsDbContext db;

        [SetUp]
        public void DbInitialization()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<NewsDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            this.db = new NewsDbContext(options);
            var articleService = new ArticleService(db);

            var author = new User() { Id = "2", UserName = "TestUser" };
            var category = new Category() { Id = 1, Name = "TestCategory" };

            var article1 = new Article() { Id = 1, Title = "Test1", Author = author, Category = category };
            var article2 = new Article() { Id = 2, Title = "Test2", Author = author, Category = category };
            var article3 = new Article() { Id = 3, Title = "Test3", Author = author, Category = category };

            db.Articles.AddRange(article1, article2, article3);
            db.SaveChanges();
        }

        [Test]
        public async Task AllArticlesAreOrderedProperly()
        {
            //Assert
            var articleService = new ArticleService(this.db);

            //Act
            var result = articleService.GetOrderedArticles("name_ascending").ToList();

            //Assert
            Assert.That(result[0].Title == "Test1");
            Assert.That(result[2].Title == "Test3");
        }

        [Test]
        public async Task ArticlesAreTakenByIdProperly()
        {
            //Assert
            var articleService = new ArticleService(this.db);

            //Act
            var result = articleService.Get(2);
            var resultTitle = result.Title;

            //Assert
            Assert.That(resultTitle == "Test2");
        }

        [Test]
        public async Task ArticlesDeletionWorkingProperly()
        {
            //Assert
            var articleService = new ArticleService(this.db);

            //Act
            articleService.Delete(2);
            var result = articleService.Get(2);

            //Assert
            Assert.That(result == null);
        }
    }
}
