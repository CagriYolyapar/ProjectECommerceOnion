using Project.Contract.RepositoryInterfaces;
using Project.DOMAIN.Entities;
using ProjectECommerce.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectECommerce.Persistence.Repositories
{
    public class AppUserRepository:BaseRepository<AppUser> , IAppUserRepository
    {
        public AppUserRepository(MyContext context):base(context)
        {

        }

        public void GetAdmins()
        {
            throw new NotImplementedException();
        }
    }
}
