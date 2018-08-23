using News.Models;
using News.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Services.Contracts
{
    public interface ICategoryService
    {
        bool Exists(int id);

        List<Category> AllCategories(string ordertype);

        IOrderedQueryable<Category> GetOrderedCategories(string ordertype);

        void Create(string name);

        void Delete(int id);

        void Edit(int id, CategoryModel model);

        Category Get(int id);
    }
}
