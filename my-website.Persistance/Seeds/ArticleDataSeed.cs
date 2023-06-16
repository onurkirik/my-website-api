using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Seeds
{
    public class ArticleDataSeed : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(
                new Article()
                {
                    Id = Guid.Parse("A44CE742-19C4-4C85-B8F1-8A2F35F9CEB4"),
                    Title = "Sample Article 1",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserId = Guid.Parse("8391C80B-C0F3-478D-A936-C4CF655F20CC"),
                    CategoryId = Guid.Parse("C9F12A78-5E28-497E-9988-6F32415DB2EA")
                },
                new Article()
                {
                    Id = Guid.Parse("50AC383A-E034-438D-97B7-3123E27837E3"),
                    Title = "Sample Article 2",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserId = Guid.Parse("8391C80B-C0F3-478D-A936-C4CF655F20CC"),
                    CategoryId = Guid.Parse("C9F12A78-5E28-497E-9988-6F32415DB2EA")
                },
                new Article()
                {
                    Id = Guid.Parse("DD69B936-A71E-458B-A198-8E1EE07807AA"),
                    Title = "Sample Article 3",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserId = Guid.Parse("8391C80B-C0F3-478D-A936-C4CF655F20CC"),
                    CategoryId = Guid.Parse("A8639731-02EF-4616-AD38-169B6A170FFB")
                },
                new Article()
                {
                    Id = Guid.Parse("B001002C-39FB-44BF-8CFC-6F72493E160D"),
                    Title = "Sample Article 4",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserId = Guid.Parse("8391C80B-C0F3-478D-A936-C4CF655F20CC"),
                    CategoryId = Guid.Parse("A8639731-02EF-4616-AD38-169B6A170FFB")
                });
        }
    }
}
