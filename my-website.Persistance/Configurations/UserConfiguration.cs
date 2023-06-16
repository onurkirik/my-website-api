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
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Adress).HasMaxLength(250);
            builder.Property(u => u.Name).HasMaxLength(50);
            builder.Property(u => u.Surname).HasMaxLength(50);

            //Relationships
            builder.HasMany<Article>()
                   .WithOne(a => a.Author)
                   .HasForeignKey(a => a.UserId);

            builder.HasMany(u => u.SocialMedias)
                   .WithOne(sm => sm.User)
                   .HasForeignKey(sm => sm.UserId);

            builder.HasMany(u => u.Certificates)
                   .WithOne(c => c.User)
                   .HasForeignKey(c => c.UserId);

            builder.HasMany(u => u.Projects)
                   .WithOne(p => p.User)
                   .HasForeignKey(p => p.UserId);

            builder.HasMany(u => u.Skills)
                   .WithOne(s => s.User)
                   .HasForeignKey(s => s.UserId);

            builder.HasMany(u => u.Experiences)
                   .WithOne(we => we.User)
                   .HasForeignKey(we => we.UserId);

            builder.HasOne(u => u.Education)
                   .WithOne(e => e.User)
                   .HasForeignKey<Education>(e => e.UserId);
        }
    }
}
