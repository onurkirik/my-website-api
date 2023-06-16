using my_website.Application.Repositories.EducationRepository;
using my_website.Domain.Entities;
using my_website.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Repositories.EducationRepository
{
    public class EducationReadRepository : ReadRepository<Education>, IEducationReadRepository
    {
        public EducationReadRepository(ApplicationDbContext context) : base(context) { }
    }
}
