﻿using Project.DOMAIN.Interfaces;
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

        Task<List<T>> GetAllAsync();
      
        Task<T> GetByIdAsync(int id);

        IQueryable<T> Where(Expression<Func<T, bool>> exp);   

        //Modification Commands
        Task CreateAsync(T entity);
        Task CreateRangeAsync(List<T> list);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(List<T> list);
        Task UpdateAsync(T originaleEntity,T newEntity);
        
      
        
      
       
    }
}
