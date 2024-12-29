using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.APPLICATION.DTOClasses
{
    public class AppUserProfileDto : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}





/*
 


ProductDto pDto = new ProductDto();
pDto.ProductName = "Tadelle";
pDto.UnitPrice = 100;




 Product  p = new Product() ;

p.ProductName =pDto.ProductName;
p.UnitPrice = pDto.UnitPrice;


_repository.Add(p);
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */