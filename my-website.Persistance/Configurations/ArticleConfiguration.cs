using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Title).HasMaxLength(200);

            builder.HasOne(a => a.Category)
                   .WithMany(c => c.Articles)
                   .HasForeignKey(a => a.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Author)
                   .WithOne(u => u.Article)
                   .HasForeignKey<AppUser>(u => u.ArticleId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
