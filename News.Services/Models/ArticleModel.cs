using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace News.Services.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "The name must be at least 5 characters")]
        public string Title { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 5, ErrorMessage = "The name must be at least 5 characters")]
        public string Content { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        [Required]
        public string Tags { get; set; }

        public string ImageUrl { get; set; }

        public string DateCreated { get; set; }
    }
}
