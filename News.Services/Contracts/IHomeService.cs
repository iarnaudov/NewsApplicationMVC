using News.Models;
using News.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Services.Contracts
{
    public interface IHomeService
    {
        List<ArticleModel> AllArticles();

        List<Category> AllCategories();
    }
}
