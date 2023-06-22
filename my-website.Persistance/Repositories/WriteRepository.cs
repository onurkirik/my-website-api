using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using my_website.Application.Repositories;
using my_website.Domain.Entities.Common;
using my_website.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_website.Persistance.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public WriteRepository(ApplicationDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            _unitOfWork.SaveChangesAsync();

            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> models)
        {
            await Table.AddRangeAsync(models);
            _unitOfWork.SaveChangesAsync();

            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            _unitOfWork.SaveChangesAsync();

            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            T model = await Table.FirstOrDefaultAsync(model => model.Id == id);
            return Remove(model);

        }

        public bool RemoveRange(List<T> models)
        {
            Table.RemoveRange(models);
            _unitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateAsync(T model)
        {
            var entityEntry = Table.Update(model);
            await _unitOfWork.SaveChangesAsync();

            return entityEntry.State == EntityState.Modified;
        }
    }
}
