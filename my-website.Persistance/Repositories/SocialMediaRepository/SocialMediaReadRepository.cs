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
    public class SocialMediaReadRepository : ReadRepository<SocialMedia>, ISocialMediaReadRepository
    {
        public SocialMediaReadRepository(ApplicationDbContext context) : base(context) { }
    }
}
