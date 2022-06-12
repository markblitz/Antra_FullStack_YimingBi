using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRMApp.WebMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServiceAsync customerServiceAsync;
        private readonly IRegionServiceAsync regionServiceAsync;
        public CustomerController(ICustomerServiceAsync customerService,
            IRegionServiceAsync regionService)
        {
            customerServiceAsync = customerService;
            regionServiceAsync = regionService;
        }

        public async Task<IActionResult> Index()
        {
            
            var collection = await customerServiceAsync.GetAllAsync();
            if (collection != null)
            {
                return View(collection);
            }
            List<CustomerResponseModel> emptyList = new List<CustomerResponseModel>();
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
        public async Task<IActionResult> Create(CustomerRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await customerServiceAsync.AddCustomerAsync(model);
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
            var editCustomer = await customerServiceAsync.GetByIdAsync(id);
            var regionCollection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(regionCollection, "Id", "Name");
            return View(editCustomer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CustomerRequestModel model)
        {
            ViewBag.IsEdit = false;
            if (ModelState.IsValid)
            {
                await customerServiceAsync.UpdateCustomerAsync(model);
                ViewBag.IsEdit = true;
            }
            var regionCollection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(regionCollection, "Id", "Name");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await customerServiceAsync.DeleteCustomerAsync(id);
            return RedirectToAction("Index");
        }
    }
}
