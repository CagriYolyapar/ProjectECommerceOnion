using Project.APPLICATION.DTOClasses;
using Project.APPLICATION.DTOInterfaces;
using Project.DOMAIN.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.APPLICATION.ServiceInterfaces
{
    public interface IManager<T, U> where T : class, IDTO where U : class, IEntity
    {

        //BL for List Comands

        Task<List<T>> GetAllAsync();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();

        //BL for Modification Commands
        Task CreateAsync(T entity);
        Task CreateRangeAsync(List<T> list);
        Task MakePassive(T entity);

        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(List<T> list);
        Task<string> RemoveAsync(T entity);
        Task<string> RemoveRangeAsync(List<T> list);





        //ICategoryManager<CategoryDto,Category>
        //IProductManager<ProductDto,Product>
    }
}
