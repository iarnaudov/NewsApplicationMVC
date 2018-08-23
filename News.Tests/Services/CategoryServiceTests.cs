using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using News.Data;
using Microsoft.EntityFrameworkCore;
using News.Services;
using News.Models;

namespace News.Tests.Services
{ 
    [TestFixture]
    public class CategoryServiceTests
    {
        private NewsDbContext db;

        [SetUp]
        public void DbInitialization()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<NewsDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            this.db = new NewsDbContext(options);
            var categoryService = new CategoryService(db);

            var author = new User() { Id = "2", UserName = "TestUser" };
            var category1 = new Category() { Id = 1, Name = "Movies" };
            var category2 = new Category() { Id = 2, Name = "Fashion" };
            var category3 = new Category() { Id = 3, Name = "Travel" };

            db.Categories.AddRange(category1, category2, category3);
            db.SaveChanges();
        }

        [Test]
        public async Task AllCategoriesAreReturned()
        {
            //Arrange
            var categoryService = new CategoryService(this.db);

            //Act
            var result = categoryService.AllCategories("name_ascending");

            //Assert
            Assert.That(result.Count == 3);
        }

        [Test]
        public async Task CategoriesExists()
        {
            //Arrange
            var categoryService = new CategoryService(this.db);

            //Act
            var result = categoryService.Exists(2);
            var result2 = categoryService.Exists(6);

            //Assert
            Assert.That(result == true);
            Assert.That(result2 == false);
        }

        [Test]
        public async Task CategoriesAreTakenByIdProperly()
        {
            //Arrange
            var categoryService = new CategoryService(this.db);
            //Act
            var result = categoryService.Get(2);
            var resultTitle = result.Name;

            //Assert
            Assert.That(resultTitle == "Fashion");
        }

        [Test]
        public async Task DeletionCategoryWorkingProperly()
        {
            //Arrange
            var categoryService = new CategoryService(this.db);
            //Act
            categoryService.Delete(2);
            var result = categoryService.Exists(2);

            //Assert
            Assert.That(result == false);
        }
    }
}
