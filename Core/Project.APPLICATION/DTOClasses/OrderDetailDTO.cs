using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.APPLICATION.DTOClasses
{
    public class OrderDetailDTO:BaseDTO
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
