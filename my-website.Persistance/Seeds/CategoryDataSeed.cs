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
    public class CategoryDataSeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category()
                {
                    Id = Guid.Parse("C9F12A78-5E28-497E-9988-6F32415DB2EA"),
                    Name = "Sample Category 1"
                },
                new Category()
                {
                    Id = Guid.Parse("A8639731-02EF-4616-AD38-169B6A170FFB"),
                    Name = "Sample Category 2"
                });
        }
    }
}
