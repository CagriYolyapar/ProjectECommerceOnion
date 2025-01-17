﻿using AutoMapper;
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
    public class CategoryManager : BaseManager<CategoryDTO,Category>,ICategoryManager
    {
        ICategoryRepository _catRep;
        IMapper _mapper;
        public CategoryManager(ICategoryRepository catRepository,IMapper mapper):base(catRepository,mapper)
        {
            _catRep = catRepository;
            _mapper = mapper;
        }
    }
}
