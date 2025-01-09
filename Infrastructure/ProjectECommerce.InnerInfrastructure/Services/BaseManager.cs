using AutoMapper;
using Project.APPLICATION.DTOInterfaces;
using Project.APPLICATION.ServiceInterfaces;
using Project.Contract.RepositoryInterfaces;
using Project.DOMAIN.Interfaces;
using ProjectECommerce.Persistence.ContextClasses;
using ProjectECommerce.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

        public List<T> GetActives()
        {
            IQueryable<U> values = _repository.Where(x => x.Status != Project.DOMAIN.Enums.DataStatus.Deleted);
            List<U> valueList = values.ToList();
            return _mapper.Map<List<T>>(valueList);

        }

        public async Task<List<T>> GetAllAsync()
        {
            List<U> values = await _repository.GetAllAsync();
            return _mapper.Map<List<T>>(values);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            U value = await _repository.GetByIdAsync(id);

            return _mapper.Map<T>(value);
        }

        public List<T> GetModifieds()
        {
            IQueryable<U> values = _repository.Where(x => x.Status == Project.DOMAIN.Enums.DataStatus.Updated);
            List<U> valueList = values.ToList();
            return _mapper.Map<List<T>>(valueList);
        }

        public List<T> GetPassives()
        {
            IQueryable<U> values = _repository.Where(x => x.Status == Project.DOMAIN.Enums.DataStatus.Deleted);
            List<U> valueList = values.ToList();
            return _mapper.Map<List<T>>(valueList);
        }

        public async Task MakePassiveAsync(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = Project.DOMAIN.Enums.DataStatus.Deleted;
            U newValue = _mapper.Map<U>(entity);
            U originalValue = await _repository.GetByIdAsync(newValue.Id);
            await _repository.UpdateAsync(originalValue, newValue);
        }

        public async Task<string> RemoveAsync(T entity)
        {
            //ONce silinmek istenen verinin pasife cekilip cekilmedigini kontrol edicem .. Eger pasife cekilmişse silicem...
            if (entity.Status != Project.DOMAIN.Enums.DataStatus.Deleted)
            {
                return "Silme işlemi sadece pasif veriler üzerinden yapılabilir";
            }
            U originalValue = await _repository.GetByIdAsync(entity.Id);

            //U originalValue = _mapper.Map<U>(entity);    => bu noktada dikkat edin bu alanda business logic olarak kendiniz özel Id'nizi yukarıdaki gibi bulmaya calısmayıp direkt maplemeye calısırsanız hata alırsınız...
            await _repository.DeleteAsync(originalValue);
            return $"Silme işlemi basarıyla gerçekleştirildi...Silinen id : {entity.Id}";
        }

        public async Task<string> RemoveRangeAsync(List<T> list)
        {
            if (list.Any(x => x.Status != Project.DOMAIN.Enums.DataStatus.Deleted))
            {
                return "Listenizde statüsü pasif olmayan bir eleman vardır...Lütfen düzenleyerek tekrar deneyiniz..";
            }

            await _repository.DeleteRangeAsync(_mapper.Map<List<U>>(list));
            return "Liste olarak silme işlemi basarılıdır";
        }

        public async Task UpdateAsync(T entity)
        {
            entity.ModifiedDate = DateTime.Now;
            entity.Status = Project.DOMAIN.Enums.DataStatus.Updated;
            U newValue = _mapper.Map<U>(entity);
            U originalValue = await _repository.GetByIdAsync(newValue.Id);
            await _repository.UpdateAsync(originalValue, newValue);
        }

        public async Task UpdateRangeAsync(List<T> list)
        {
            foreach (T item in list) await UpdateAsync(item);

        }
    }
}
