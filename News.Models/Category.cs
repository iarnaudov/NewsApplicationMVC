using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        public string Name { get; set; }

        public List<Article> Articles { get; set; } = new List<Article>();

        public Category()
        {

        }

        public Category(string name)
        {
            this.Name = name;
        }

    }
}