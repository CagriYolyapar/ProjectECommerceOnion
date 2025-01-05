using System.ComponentModel.DataAnnotations;

namespace ProjectECommerce.WebApi.ViewModels.RequestModels.Categories
{
    public class CreateCategoryRequestModel
    {
        [Required(ErrorMessage ="Kategori ismi zorunludur")]
        public string CategoryName { get; set; }
        public string Description { get; set; }

    }
}
