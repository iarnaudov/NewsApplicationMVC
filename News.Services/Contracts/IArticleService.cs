using News.Models;
using News.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace News.Services.Contracts
{
    public interface IArticleService
    { 
        ArticleModel FindArticle(int id);

        Article Get(int id);

        void Create(ArticleModel model);

        void Delete(int id);

        void Edit(int id, ArticleModel model);

        List<Article> GetOrderedArticles(string ordertype);

        List<Article> GetAllByType(string type);
    }
}
