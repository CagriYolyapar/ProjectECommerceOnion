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
    public class AppUserManager : BaseManager<AppUserDTO,AppUser>, IAppUserManager
    {
        IAppUserRepository _appUserRep;
        IMapper _mapper;
        public AppUserManager(IAppUserRepository appUserRep,IMapper mapper) : base(appUserRep,mapper) 
        {
            _appUserRep = appUserRep;
            _mapper = mapper;

           
           
        }
    }
}
