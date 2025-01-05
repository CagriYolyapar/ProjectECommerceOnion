using Microsoft.EntityFrameworkCore;
using Project.Contract.RepositoryInterfaces;
using Project.DOMAIN.Interfaces;
using ProjectECommerce.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectECommerce.Persistence.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        readonly MyContext _context;
     
        protected BaseRepository(MyContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task CreateRangeAsync(List<T> list)
        {
            await _context.Set<T>().AddRangeAsync(list);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(List<T> list)
        {
            _context.Set<T>().RemoveRange(list);
            await _context.SaveChangesAsync();
        }

   

     

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

     

        public async Task UpdateAsync(T originalEntity,T newEntity)
        {
            _context.Entry(originalEntity).CurrentValues.SetValues(newEntity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp);
        }
    }
}
