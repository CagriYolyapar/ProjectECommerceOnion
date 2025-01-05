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
    public class AppUserProfileManager : BaseManager<AppUserProfileDto,AppUserProfile>,IAppUserProfileManager
    {
        IAppUserProfileRepository _appProRep;
        IMapper _mapper;
        public AppUserProfileManager(IAppUserProfileRepository appProRep,IMapper mapper):base(appProRep,mapper) 
        {
            _appProRep = appProRep;
            _mapper = mapper;
        }
    }
}
