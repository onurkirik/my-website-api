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
    public class WorkExperienceConfiguration : IEntityTypeConfiguration<WorkExperience>
    {
        public void Configure(EntityTypeBuilder<WorkExperience> builder)
        {
            builder.HasKey(w => w.Id);
        }
    }
}
