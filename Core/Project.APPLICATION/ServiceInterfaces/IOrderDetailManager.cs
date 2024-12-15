﻿using Project.APPLICATION.DTOClasses;
using Project.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.APPLICATION.ServiceInterfaces
{
    public interface IOrderDetailManager:IManager<OrderDetailDTO,OrderDetail>
    {
    }
}