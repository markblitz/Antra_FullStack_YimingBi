using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServiceAsync employeeServiceAsync;
        public EmployeeController(IEmployeeServiceAsync employeeServiceAsync)
        {
            this.employeeServiceAsync = employeeServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await employeeServiceAsync.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await employeeServiceAsync.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound($"Employee with Id = {id} is not found!");
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(EmployeeRequestModel employeeRequestModel)
        {
            var result = await employeeServiceAsync.AddEmployeeAsync(employeeRequestModel);
            if (result > 0) { return Ok(employeeRequestModel); }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(EmployeeRequestModel employeeRequestModel)
        {
            var result = await employeeServiceAsync.UpdateEmployeeAsync(employeeRequestModel);
            if (result > 0) { return Ok(employeeRequestModel); }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await employeeServiceAsync.DeleteEmployeeAsync(id);
            if (result > 0)
            {
                var response = new { Message = "Delete Successfully" };
                return Ok(response);
            }
            return BadRequest();
        }
    }
}
