using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Models;
using News.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Tests.Services
{
    public class UserServiceTests
    {
        private NewsDbContext db;

        [SetUp]
        public void DbInitialization()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<NewsDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            this.db = new NewsDbContext(options);
            var userService = new UserService(db);

            var user1 = new User() { Id = "1", UserName = "Nikolai" };
            var user2 = new User() { Id = "2", UserName = "Yordan" };
            var user3 = new User() { Id = "3", UserName = "Teo" };
            var user4 = new User() { Id = "4", UserName = "Ivo" };
       

            db.Users.AddRange(user1, user2, user3, user4);
            db.SaveChanges();
        }


        [Test]
        public void AllUsersAreReturned()
        {
            //Arrange
            var userService = new UserService(db);

            //Act
            var result = userService.GetAll();

            //Assert
            Assert.That(result.Count == 4);
        }

        [Test]
        public void CorrectUserIsRetrievedById()
        {
            //Arrange
            var userService = new UserService(db);

            //Act
            var result = userService.GetById("2");

            //Assert
            Assert.That(result.UserName == "Yordan");
        }

        [Test]
        public void UserDeletionIsProperlyImplemented()
        {
            //Arrange
            var userService = new UserService(db);

            //Act
            userService.DeleteUserById("3");
            var deletedUser = userService.GetById("3");

            //Assert
            Assert.That(deletedUser == null);
        }


    }
}
