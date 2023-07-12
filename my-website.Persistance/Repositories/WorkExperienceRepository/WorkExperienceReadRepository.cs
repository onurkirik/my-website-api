using my_website.Application.Repositories.WorkExperienceRepository;
using my_website.Domain.Entities;
using my_website.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Repositories.WorkExperienceRepository
{
    public class WorkExperienceReadRepository : ReadRepository<WorkExperience>, IWorkExperienceReadRepository
    {
        public WorkExperienceReadRepository(ApplicationDbContext context) : base(context) { }
    }
}
