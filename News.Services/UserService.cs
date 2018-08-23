using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using News.Data;
using News.Models;
using News.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace News.Services
{
    public class UserService : IUserService
    {
        private readonly NewsDbContext db;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _http;

        public UserService(NewsDbContext db)
        {
            this.db = db;
        }

        public UserService(NewsDbContext db, UserManager<User> userManager, IHttpContextAccessor http)
        {
            this.db = db;
            this._userManager = userManager;
            this._http = http;
        }

        public List<User> GetAll()
        {
            var users = this.db.Users.ToList();
            return users;
        }

        public User GetById(string id)
        {
            var user = this.db.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public void DeleteUserById(string id)
        {
            var user = this.db.Users.FirstOrDefault(u => u.Id == id);
            this.db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}
