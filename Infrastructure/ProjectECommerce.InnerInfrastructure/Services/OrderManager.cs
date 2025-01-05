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
    public class OrderManager :BaseManager<OrderDTO,Order>,IOrderManager
    {
        IOrderRepository _oRep;
        IMapper _mapper;
        public OrderManager(IOrderRepository oRep,IMapper mapper):base(oRep,mapper)
        {
            _oRep = oRep;
            _mapper = mapper;
        }
    }
}
