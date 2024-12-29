using AutoMapper;
using Project.APPLICATION.DTOInterfaces;
using Project.APPLICATION.ServiceInterfaces;
using Project.Contract.RepositoryInterfaces;
using Project.DOMAIN.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectECommerce.InnerInfrastructure.Services
{
    public abstract class BaseManager<T, U> : IManager<T, U> where T : class, IDTO where U : class, IEntity
    {
        readonly IRepository<U> _repository;
        readonly IMapper _mapper;

        public BaseManager(IRepository<U> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task CreateAsync(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.Status = Project.DOMAIN.Enums.DataStatus.Inserted;

            U domainEntity = _mapper.Map<U>(entity);

            await _repository.CreateAsync(domainEntity);
        }

        public async Task CreateRangeAsync(List<T> list)
        {
            foreach (T item in list)
            {
                await CreateAsync(item);
            }

            //List<U> domainEntityList = _mapper.Map<List<U>>(list);
            //await _repository.CreateRangeAsync(domainEntityList);
        }

        public  List<T> GetActives()
        {
            IQueryable<U> activeEntities =  _repository.GetActives();
            return _mapper.Map<IQueryable<T>>(activeEntities).ToList();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public List<T> GetModifieds()
        {
            throw new NotImplementedException();
        }

        public List<T> GetPassives()
        {
            throw new NotImplementedException();
        }

        public Task MakePassive(T entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRangeAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(List<T> list)
        {
            throw new NotImplementedException();
        }
    }
}
