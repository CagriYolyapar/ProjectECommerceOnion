using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using Project.APPLICATION.DTOClasses;
using Project.APPLICATION.ServiceInterfaces;
using ProjectECommerce.WebApi.ViewModels.RequestModels.Categories;
using ProjectECommerce.WebApi.ViewModels.ResponseModels.Categories;

namespace ProjectECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        ICategoryManager _catManager;
        IMapper _mapper;

        public CategoryController(ICategoryManager catManager, IMapper mapper)
        {
            _catManager = catManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            List<CategoryDTO> categories = await _catManager.GetAllAsync();
            return Ok(_mapper.Map<List<CategoryResponseModel>>(categories));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            CategoryDTO value = await _catManager.GetByIdAsync(id);
            return Ok(_mapper.Map<CategoryResponseModel>(value));

        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestModel category)
        {
            //Validation işlemleri yapılır...
            await _catManager.CreateAsync(_mapper.Map<CategoryDTO>(category));
            return Ok("Kategori eklendi");

        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryRequestModel category)
        {
            //Validation İslemleri yapılır
            await _catManager.UpdateAsync(_mapper.Map<CategoryDTO>(category));
            return Ok("Güncelleme basarılır");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            CategoryDTO value = await _catManager.GetByIdAsync(id);
            string mesaj =await _catManager.RemoveAsync(value);

            return Ok(mesaj);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PasifyCategory(int id)
        {
            CategoryDTO category = await _catManager.GetByIdAsync(id);
            await _catManager.MakePassiveAsync(category);
            return Ok("Veri pasife cekilmiştir");
        }
    }
}
