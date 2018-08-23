using News.Models;
using News.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace News.Web.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<ArticleModel> Articles { get; set; }

        public List<Category> Categories { get; set; }

    }
}
