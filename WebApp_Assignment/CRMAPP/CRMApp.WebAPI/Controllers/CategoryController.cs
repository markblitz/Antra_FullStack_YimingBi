using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServiceAsync categoryServiceAsync;
        public CategoryController(ICategoryServiceAsync categoryServiceAsync)
        {
            this.categoryServiceAsync = categoryServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await categoryServiceAsync.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await categoryServiceAsync.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound($"Category with Id = {id} is not found!");
            }
            return Ok(category);
        }

        [HttpGet]
        [Route("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            throw new NotImplementedException("Can not get region information by name!");
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryModel categoryModel)
        {
            var result = await categoryServiceAsync.AddCategoryAsync(categoryModel);
            if (result > 0) { return Ok(categoryModel); }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryModel categoryModel)
        {
            var result = await categoryServiceAsync.UpdateCategoryAsync(categoryModel);
            if (result > 0) { return Ok(categoryModel); }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await categoryServiceAsync.DeleteCategoryAsync(id);
            if (result > 0) {
                var response = new { Message = "Delete Successfully" };
                return Ok(response); 
            }
            return BadRequest();
        }
    }
}
