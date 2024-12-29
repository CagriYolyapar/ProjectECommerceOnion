using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DOMAIN.Entities
{
    public class AppUser: BaseEntity
    {
      
        public string UserName { get; set; }
        public string Password { get; set; }
     

        //Relational Properties
        public virtual ICollection<Order> Orders { get; set; }
        public virtual AppUserProfile AppUserProfile { get; set; }


        //AppUser.Orders

        //Order.AppUser
    }
}
