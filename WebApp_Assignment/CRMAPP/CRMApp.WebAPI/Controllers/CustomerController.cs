using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServiceAsync customerServiceAsync;
        public CustomerController(ICustomerServiceAsync customerServiceAsync)
        {
            this.customerServiceAsync = customerServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await customerServiceAsync.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await customerServiceAsync.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound($"Customer with Id = {id} is not found!");
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CustomerRequestModel customerRequestModel)
        {
            var result = await customerServiceAsync.AddCustomerAsync(customerRequestModel);
            if (result > 0) { return Ok(customerRequestModel); }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CustomerRequestModel customerRequestModel)
        {
            var result = await customerServiceAsync.UpdateCustomerAsync(customerRequestModel);
            if (result > 0) { return Ok(customerRequestModel); }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await customerServiceAsync.DeleteCustomerAsync(id);
            if (result > 0)
            {
                var response = new { Message = "Delete Successfully" };
                return Ok(response);
            }
            return BadRequest();
        }
    }
}
