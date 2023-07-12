using my_website.Application.Repositories;
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
    public class WorkExperienceWriteRepository : WriteRepository<WorkExperience>, IWorkExperienceWriteRepository
    {
        public WorkExperienceWriteRepository(ApplicationDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork) { }
    }
}
