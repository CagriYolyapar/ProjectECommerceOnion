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
    public class OrderDetailManager : BaseManager<OrderDetailDTO,OrderDetail>,IOrderDetailManager
    {
        IOrderDetailRepository _odRep;
        IMapper _mapper;
        public OrderDetailManager(IOrderDetailRepository odRep, IMapper mapper):base(odRep, mapper) 
        {
            _odRep = odRep;
            _mapper = mapper;
        }
    }
}
