using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRMApp.WebMVC.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierServiceAsync supplierServiceAsync;
        private readonly IRegionServiceAsync regionServiceAsync;
        public SupplierController(ISupplierServiceAsync supplierService,
            IRegionServiceAsync regionService)
        {
            supplierServiceAsync = supplierService;
            regionServiceAsync = regionService;
        }

        public async Task<IActionResult> Index()
        {
            var collection = await supplierServiceAsync.GetAllAsync();
            if (collection != null)
            {
                return View(collection);
            }
            List<SupplierResponseModel> emptyList = new List<SupplierResponseModel>();
            return View(emptyList);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var regionCollection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(regionCollection, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SupplierRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await supplierServiceAsync.AddSupplierAsync(model);
                return Redirect("Index");
            }
            var regionCollection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(regionCollection, "Id", "Name");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.IsEdit = false;
            var editEmployee = await supplierServiceAsync.GetByIdAsync(id);
            var regionCollection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(regionCollection, "Id", "Name");
            return View(editEmployee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SupplierRequestModel model)
        {
            ViewBag.IsEdit = false;
            if (ModelState.IsValid)
            {
                await supplierServiceAsync.UpdateSupplierAsync(model);
                ViewBag.IsEdit = true;
            }
            var regionCollection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(regionCollection, "Id", "Name");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await supplierServiceAsync.DeleteSupplierAsync(id);
            return RedirectToAction("Index");
        }
    }
}
