using my_website.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> models);
        Task<bool> Remove(T model);
        Task<bool> RemoveRange(List<T> models);
        Task<bool> RemoveAsync(Guid id);
        Task<bool> UpdateAsync(T model);
    }
}
