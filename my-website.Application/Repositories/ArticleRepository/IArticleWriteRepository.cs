using my_website.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.Repositories.ArticleRepository
{
    public interface IArticleWriteRepository : IWriteRepository<Article>
    {
    }
}
