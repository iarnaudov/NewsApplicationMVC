using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using News.Services.Contracts;
using News.Data;
using News.Services.Models;
using News.Models;

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
            var articlesList = this.db.Articles.Include(c => c.Author).Include(a => a.Category).ToList();
            articlesList = articlesList.ToList();

            var articlesModel = articlesList.Select(c => new ArticleModel
            {
                Id = c.Id,
                Content = c.Content,
                Title = c.Title,
                Category = c.Category.Name,
                Author = c.Author.UserName,
            }).ToList();

            return articlesModel;
        }

        public List<Category> AllCategories()
        {
            var categoriesList = this.db.Categories.Include(c => c.Articles).ToList();

            return categoriesList;
        }

        private void SeedData()
        {
            //var likesList3 = new List<Like>();
            //likesList3.Add(new Like("Like"));
            //likesList3.Add(new Like("Like"));
            //likesList3.Add(new Like("Like"));
            //likesList3.Add(new Like("Like"));


            //var likesList = new List<Like>();
            //likesList.Add(new Like("Like"));
            //likesList.Add(new Like("Like"));
            //likesList.Add(new Like("Like"));
            //likesList.Add(new Like("Like"));
            //likesList.Add(new Like("Like"));

            //var likesList4 = new List<Like>();
            //likesList4.Add(new Like("Like"));
            //likesList4.Add(new Like("Like"));
            //likesList4.Add(new Like("Dislike"));


            //var likesList2 = new List<Like>();
            //likesList2.Add(new Like("Like"));
            //likesList2.Add(new Like("Like"));
            //likesList2.Add(new Like("Like"));
            //likesList2.Add(new Like("Like"));
            //likesList2.Add(new Like("Dislike"));
            //likesList2.Add(new Like("Like"));
            //likesList2.Add(new Like("Like"));


            //var articles = new List<Article>();
            //articles.Add(new Article("The man mountain switching military maneuvers for the judo mat", "The Briton was recently crowned national champion in the 100+kg category and now has his sights set on the 2020 Tokyo Olympics. He was also a relative latecomer to the military, joining the Royal Air Force aged 24 and finding himself in a war zone just six weeks later.", 1, "a095b444-b153-43f9-90ed-4c91011afe3f", likesList2));
            //articles.Add(new Article("15 must-see attractions on the Las Vegas Strip", "Las Vegas Boulevard -- the world-famous Las Vegas Strip -- is the central artery of Sin City and the main line to a majority of the city's best sights, gambling, food and fun. With neon signs and dancing fountains along an eight-mile stretch of awesome, the Strip delivers sensory overload.", 2, "e2bc7bd8-c364-437d-86a6-f65cdcdc6f19", likesList));
            //articles.Add(new Article("Lady Gaga explains why Donatella Versace is an icon", "Donatella Versace is one of the fashion industry's most recognizable figures. Versace's fans call her an icon, a title that was further established at the Fashion Awards hosted in London at the end of last year when she received the Fashion Icon award.", 3, "a095b444-b153-43f9-90ed-4c91011afe3f", likesList3));
            //articles.Add(new Article("Simplifying art for the sake of politics", "Trotsky was criticizing the Futurists' rejection of realism in favor of abstraction, questioning whether art could ever be a  without holding a to society. But while subsequent generations of artists might disagree with Trotsky's politics, the idea that art can and should represent real experience and have an impact on politics has become commonplace.", 3, "e2bc7bd8-c364-437d-86a6-f65cdcdc6f19", likesList3));

            //var category = new Category("Google");

            //this.db.Articles.AddRange(articles);
            //this.db.Categories.Add(category);
            //this.db.SaveChanges();
        }
    }
}
