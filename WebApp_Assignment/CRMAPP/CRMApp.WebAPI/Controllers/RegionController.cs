using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionServiceAsync regionServiceAsync;
        public RegionController(IRegionServiceAsync regionServiceAsync)
        {
            this.regionServiceAsync = regionServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await regionServiceAsync.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await regionServiceAsync.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound($"Employee with Id = {id} is not found!");
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(RegionModel regionModel)
        {
            var result = await regionServiceAsync.AddRegionAsync(regionModel);
            if (result > 0) { return Ok(regionModel); }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(RegionModel regionModel)
        {
            var result = await regionServiceAsync.UpdateRegionAsync(regionModel);
            if (result > 0) { return Ok(regionModel); }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await regionServiceAsync.DeleteRegionAsync(id);
            if (result > 0)
            {
                var response = new { Message = "Delete Successfully" };
                return Ok(response);
            }
            return BadRequest();
        }
    }
}
