using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.Repositories
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
