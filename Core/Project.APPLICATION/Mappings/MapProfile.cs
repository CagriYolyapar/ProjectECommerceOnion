using AutoMapper;
using Project.APPLICATION.DTOClasses;
using Project.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.APPLICATION.Mappings
{
    public class MapProfile :Profile
    {
        public MapProfile()
        {
            //CreateMap bir mapleme sistemi yaratarak hangi tipi hangi tipe mapleyecegimizi anlatır...ReverseMap ise ilk basta belirtilen ifadedeki tiplerin tam tersi maplemesini yapar.
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<AppUser, AppUserDTO>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();
            CreateMap<AppUserProfile,AppUserProfileDto>().ReverseMap();
            //CreateMap<BaseDTO, BaseEntity>().ReverseMap(); 
            //ToDo:Experimental  Dto'ların IManager yapısında maplenmesi durumunda bir karısıklık cıkacak mı diye test edilecek

           
        }
    }
}
