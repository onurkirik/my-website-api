using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Configurations
{
    public class SkillsConfiguration : IEntityTypeConfiguration<Skills>
    {
        public void Configure(EntityTypeBuilder<Skills> builder)
        {
            builder.HasKey(s => s.Id);
        }
    }
}
