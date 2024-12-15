using Project.APPLICATION.DTOClasses;
using Project.APPLICATION.DTOInterfaces;
using Project.DOMAIN.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.APPLICATION.ServiceInterfaces
{
    public interface IManager<T,U> where T: class,IDTO where U:class,IEntity
    {

        //BL for List Comands

        Task<List<T>> GetAllAsync();
        Task<List<T>> GetActivesAsync();
        Task<List<T>> GetPassivesAsync();
        Task<List<T>> GetModifiedsAsync();

        //BL for Modification Commands
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
