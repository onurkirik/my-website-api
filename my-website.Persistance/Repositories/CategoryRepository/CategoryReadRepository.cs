using my_website.Application.Repositories;
using my_website.Application.Repositories.CategoryRepository;
using my_website.Domain.Entities;
using my_website.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Repositories.CategoryRepository
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(ApplicationDbContext context) : base(context) { }
    }
}
