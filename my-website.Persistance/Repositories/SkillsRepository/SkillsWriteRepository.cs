using my_website.Application.Repositories;
using my_website.Application.Repositories.SkillsRepository;
using my_website.Domain.Entities;
using my_website.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Repositories.SkillsRepository
{
    public class SkillsWriteRepository : WriteRepository<Skills>, ISkillWriteRepository
    {
        public SkillsWriteRepository(ApplicationDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork) { }
    }
}
