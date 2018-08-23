using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Models;
using News.Services.Contracts;
using News.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace News.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly NewsDbContext db;

        public CategoryService(NewsDbContext db)
        {
            this.db = db;
        }

        public List<Category> AllCategories(string ordertype)
        {
            var categoriesList = this.db.Categories.ToList();

            switch (ordertype)
            {
                case "name_ascending": categoriesList = categoriesList.OrderBy(a => a.Name).ToList(); break;
                case "name_descending": categoriesList = categoriesList.OrderByDescending(a => a.Name).ToList(); break;
                default: break;
            }
            return categoriesList;
        }

        public IOrderedQueryable<Category> GetOrderedCategories(string ordertype)
        {
            if (string.IsNullOrWhiteSpace(ordertype))
            {
                ordertype = "name_ascending";
            }


            IOrderedQueryable<Category> categoryList;

            switch (ordertype)
            {
                case "name_ascending": categoryList = this.db.Categories.AsNoTracking().OrderBy(a => a.Name); break;
                case "name_descending": categoryList = this.db.Categories.AsNoTracking().OrderByDescending(a => a.Name); break;
                default: categoryList = null; break;
            }

            return categoryList;
        }

        public void Create(string name)
        {
            var category = new Category
            {
                Name = name
            };

            this.db.Categories.Add(category);
            this.db.SaveChanges();
        }

        public void Delete(int id)
        {
            var categories = this.db.Categories.ToList();
            var categoryForRemove = categories.SingleOrDefault(c => c.Id == id);
            this.db.Categories.Remove(categoryForRemove);
            this.db.SaveChanges();
        }

        public void Edit(int id, CategoryModel model)
        {
            var categoryForEdit = this.db.Categories.Find(id);

            if (categoryForEdit == null)
            {
                return;
            }

            categoryForEdit.Name = model.Name;
            this.db.SaveChanges();
        }

        public bool Exists(int id)
        {
             var result =  this.db.Categories.Any(c => c.Id == id);
             return result;
        }

        public Category Get(int id)
        {
            var categories = this.db.Categories.ToList();
            var categoryForEdit = categories.SingleOrDefault(c => c.Id == id);
            return categoryForEdit;
        }

    }
}
