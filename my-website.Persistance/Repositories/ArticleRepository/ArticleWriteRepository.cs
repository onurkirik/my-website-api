using my_website.Application.Repositories;
using my_website.Application.Repositories.ArticleRepository;
using my_website.Domain.Entities;
using my_website.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Repositories.ArticleRepository
{
    public class ArticleWriteRepository : WriteRepository<Article>, IArticleWriteRepository
    {
        public ArticleWriteRepository(ApplicationDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork) { }
    }
}
