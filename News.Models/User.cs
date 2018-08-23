using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace News.Models
{
    public class User : IdentityUser
    {
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}