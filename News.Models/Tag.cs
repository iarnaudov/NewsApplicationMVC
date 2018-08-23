using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(25)]
        public string Name { get; set; }

        public Tag(string name)
        {
            Name = name;
        }
    }
}