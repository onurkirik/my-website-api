using my_website.Application.Repositories;
using my_website.Application.Repositories.SocialMediaRepository;
using my_website.Domain.Entities;
using my_website.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Repositories.SocialMediaRepository
{
    public class SocialMediaWriteRepository : WriteRepository<SocialMedia>, ISocialMediaWriteRepository
    {
        public SocialMediaWriteRepository(ApplicationDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork) { }
    }
}
