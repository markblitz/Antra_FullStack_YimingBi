using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperServiceAsync shipperServiceAsync;
        public ShipperController(IShipperServiceAsync shipperServiceAsync)
        {
            this.shipperServiceAsync = shipperServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await shipperServiceAsync.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await shipperServiceAsync.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound($"Employee with Id = {id} is not found!");
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(ShipperModel shipperModel)
        {
            var result = await shipperServiceAsync.AddShipperAsync(shipperModel);
            if (result > 0) { return Ok(shipperModel); }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(ShipperModel shipperModel)
        {
            var result = await shipperServiceAsync.UpdateShipperAsync(shipperModel);
            if (result > 0) { return Ok(shipperModel); }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await shipperServiceAsync.DeleteShipperAsync(id);
            if (result > 0) { return Ok($"Employee with Id = {id} has been deleted!"); }
            return BadRequest();
        }
    }
}
