using my_website.Application.Repositories.ProjectRepository;
using my_website.Domain.Entities;
using my_website.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Repositories.ProjectRepository
{
    public class ProjectReadRepository : ReadRepository<Project>, IProjectReadRepository
    {
        public ProjectReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
