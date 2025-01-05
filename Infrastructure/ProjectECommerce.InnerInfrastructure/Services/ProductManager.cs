using AutoMapper;
using Project.APPLICATION.DTOClasses;
using Project.APPLICATION.ServiceInterfaces;
using Project.Contract.RepositoryInterfaces;
using Project.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectECommerce.InnerInfrastructure.Services
{
    public class ProductManager : BaseManager<ProductDTO, Product>, IProductManager
    {
        IProductRepository _proRep;
        IMapper _mapper;
        public ProductManager(IProductRepository proRep, IMapper mapper) : base(proRep, mapper)
        {
            _proRep = proRep;
            _mapper = mapper;
        }

        public async Task<string> CreateSpecialProduct(ProductDTO productDto)
        {
            if (productDto.CategoryId == null)
            {
                return "Ürün eklenemez cünkü kategorisi yoktur";
            }

            await _proRep.CreateAsync(_mapper.Map<Product>(productDto));
            return "Ürün ekleme basarılıdr";

        }
    }
}
