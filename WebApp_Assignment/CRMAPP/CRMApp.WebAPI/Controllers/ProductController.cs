using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServiceAsync productServiceAsync;
        public ProductController(IProductServiceAsync productServiceAsync)
        {
            this.productServiceAsync = productServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await productServiceAsync.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await productServiceAsync.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound($"Product with Id = {id} is not found!");
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(ProductRequestModel productRequestModel)
        {
            var result = await productServiceAsync.AddProductAsync(productRequestModel);
            if (result > 0) { return Ok(productRequestModel); }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(ProductRequestModel productRequestModel)
        {
            var result = await productServiceAsync.UpdateProductAsync(productRequestModel);
            if (result > 0) { return Ok(productRequestModel); }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await productServiceAsync.DeleteProductAsync(id);
            if (result > 0) { return Ok($"Product with Id = {id} has been deleted!"); }
            return BadRequest();
        }
    }
}
