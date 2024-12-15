using Project.DOMAIN.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Contract.RepositoryInterfaces
{
    public interface IRepository<T> where T:class,IEntity
    {
        //List Commands

        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> GetActivesAsync();
        Task<IQueryable<T>> GetPassivesAsync();
        Task<IQueryable<T>> GetModifiedsAsync();
        T GetById(int id);

        //Modification Commands
        Task CreateAsync(T entity);
        Task CreateRangeAsync(List<T> list);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(List<T> list);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(List<T> list);
        Task DestroyAsync(T entity);
        Task DestroyRangeAsync(T entity);
        
       
    }
}
