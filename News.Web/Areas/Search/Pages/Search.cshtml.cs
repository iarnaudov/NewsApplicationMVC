using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace News.Web.Areas.Account.Pages
{
    public class SearchModel : PageModel
    {
        private readonly NewsDbContext db;

        public SearchModel(NewsDbContext context)
        {
            db = context;
        }

        public string SearchTerm { get; set; }

        public Dictionary<int, string> Results { get; set; } = new Dictionary<int, string>();

        public void OnPostSearch(string searchTerm)
        {
            this.SearchTerm = searchTerm;

            var articleTitleResults = this.db.Articles.Where(a => a.Title.Contains(searchTerm)).ToList();

            foreach (var item in articleTitleResults)
            {
                if (!this.Results.Keys.Contains(item.Id))
                {
                    this.Results.Add(item.Id, item.Title + " (Title)");
                }
            }

            var articleTags = this.db.Tags.Where(t => t.Name.Contains(searchTerm)).ToList();

            foreach (var tag in articleTags)
            {
                var articles = this.db.ArticleTags.Where(a => a.TagId == tag.Id).Select(b => b.Article).ToList();

                foreach (var article in articles)
                {
                    if(!this.Results.Keys.Contains(article.Id))
                    {
                        this.Results.Add(article.Id, article.Title + " (Tag)");
                    }
                }
            }



        }
    }
}