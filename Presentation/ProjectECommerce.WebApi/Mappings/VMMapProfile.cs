using AutoMapper;
using Project.APPLICATION.DTOClasses;
using ProjectECommerce.WebApi.ViewModels.RequestModels.Categories;
using ProjectECommerce.WebApi.ViewModels.ResponseModels.Categories;

namespace ProjectECommerce.WebApi.Mappings
{
    public class VMMapProfile : Profile
    {
        public VMMapProfile()
        {
            CreateMap<CategoryDTO, CategoryResponseModel>();
            CreateMap<CreateCategoryRequestModel, CategoryDTO>();
            CreateMap<UpdateCategoryRequestModel, CategoryDTO>();
        }
    }
}
