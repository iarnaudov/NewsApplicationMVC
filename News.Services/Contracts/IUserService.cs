using News.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Services.Contracts
{
    public interface IUserService
    {
        List<User> GetAll();

        User GetById(string id);

        void DeleteUserById(string id);
    }
}
