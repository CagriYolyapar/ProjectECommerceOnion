using Project.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Contract.RepositoryInterfaces
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        void GetAdmins();
    }
}
