using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5), MaxLength(300)]
        public string Title { get; set; }

        [Required]
        [MinLength(10), MaxLength(2000)]
        public string Content { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required]
        public string AuthorId { get; set; }

        public User Author { get; set; }

        public DateTime TimeCreated { get; set; }

        public string ImageUrl { get; set; }

        public Article()
        {

        }

        public Article(string title, string content, int categoryId, string authorid)
        {
            this.Title = title;
            this.Content = content;
            this.CategoryId = categoryId;
            this.AuthorId = authorid;
        }
    }
}
