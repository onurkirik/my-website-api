using Microsoft.EntityFrameworkCore;
using my_website.Application.Repositories.ArticleRepository;
using my_website.Domain.Entities;
using my_website.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Repositories.ArticleRepository
{
    public class ArticleReadRepository : ReadRepository<Article>, IArticleReadRepository
    {
        public ArticleReadRepository(ApplicationDbContext context) : base(context) { }

        public override IQueryable<Article> GetAll(bool tracking = true)
        {
            var query = base.GetAll(tracking);
            query = query.Include(a => a.Author)
                         .Include(a => a.Category);
            return query;
        }

        public override async Task<Article> GetByIdAsync(Guid id, bool tracking)
        {
            var query = base.Table.AsQueryable();

            if (!tracking)
                query = query.AsNoTracking();

            query = query.Where(data => data.Id == id)
                         .Include(a => a.Author)
                         .Include(a => a.Category);

            return await query.FirstOrDefaultAsync();
        }

    }
}
