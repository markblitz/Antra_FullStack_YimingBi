using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierServiceAsync supplierServiceAsync;
        public SupplierController(ISupplierServiceAsync supplierServiceAsync)
        {
            this.supplierServiceAsync = supplierServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await supplierServiceAsync.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await supplierServiceAsync.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound($"Employee with Id = {id} is not found!");
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(SupplierRequestModel supplierRequestModel)
        {
            var result = await supplierServiceAsync.AddSupplierAsync(supplierRequestModel);
            if (result > 0) { return Ok(supplierRequestModel); }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(SupplierRequestModel supplierRequestModel)
        {
            var result = await supplierServiceAsync.UpdateSupplierAsync(supplierRequestModel);
            if (result > 0) { return Ok(supplierRequestModel); }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await supplierServiceAsync.DeleteSupplierAsync(id);
            if (result > 0) { return Ok($"Employee with Id = {id} has been deleted!"); }
            return BadRequest();
        }
    }
}
