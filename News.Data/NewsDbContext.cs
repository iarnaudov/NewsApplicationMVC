using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using News.Models;
using System;

namespace News.Data
{
    public class NewsDbContext : IdentityDbContext<User>
    {

        public NewsDbContext(DbContextOptions<NewsDbContext> options)
            : base(options)
        {
        }


        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Article>()
             .HasOne(s => s.Author)
             .WithMany(p => p.Articles)
             .HasForeignKey(s => s.AuthorId);

            builder.Entity<Article>()
            .HasOne(s => s.Category)
            .WithMany(p => p.Articles)
            .HasForeignKey(s => s.CategoryId);

            builder.Entity<ArticleTag>()
              .HasKey(at => new { at.ArticleId, at.TagId });

            //builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Moderator", NormalizedName = "Moderator".ToUpper() });
        }
    }
}
