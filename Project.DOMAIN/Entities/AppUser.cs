﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DOMAIN.Entities
{
    public class AppUser:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual ICollection<Order> Orders { get; set; }



        //AppUser.Orders

        //Order.AppUser
    }
}