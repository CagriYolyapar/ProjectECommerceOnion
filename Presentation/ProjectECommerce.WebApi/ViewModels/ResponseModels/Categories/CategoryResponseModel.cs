namespace ProjectECommerce.WebApi.ViewModels.ResponseModels.Categories
{
    public class CategoryResponseModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public string ShowStyle { get { return $"{CategoryName}-{Description}"; } }

    }
}
