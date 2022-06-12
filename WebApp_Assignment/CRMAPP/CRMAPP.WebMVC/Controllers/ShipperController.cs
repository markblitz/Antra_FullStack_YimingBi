using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebMVC.Controllers
{
    public class ShipperController : Controller
    {
        private readonly IShipperServiceAsync shipperServiceAsync;
        public ShipperController(IShipperServiceAsync shipperService)
        {
            shipperServiceAsync = shipperService;
        }

        public async Task<IActionResult> Index()
        {
            var collection = await shipperServiceAsync.GetAllAsync();
            if (collection != null)
            {
                return View(collection);
            }
            List<ShipperModel> emptyList = new List<ShipperModel>();
            return View(emptyList);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShipperModel model)
        {
            if (ModelState.IsValid)
            {
                await shipperServiceAsync.AddShipperAsync(model);
                return Redirect("Index");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.IsEdit = false;
            var editShipper = await shipperServiceAsync.GetByIdAsync(id);
            return View(editShipper);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ShipperModel model)
        {
            ViewBag.IsEdit = false;
            if (ModelState.IsValid)
            {
                await shipperServiceAsync.UpdateShipperAsync(model);
                ViewBag.IsEdit = true;
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await shipperServiceAsync.DeleteShipperAsync(id);
            return RedirectToAction("Index");
        }
    }
}
