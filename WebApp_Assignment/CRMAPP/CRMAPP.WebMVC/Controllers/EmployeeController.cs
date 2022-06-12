using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRMApp.WebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServiceAsync employeeServiceAsync;
        private readonly IRegionServiceAsync regionServiceAsync;
        public EmployeeController(IEmployeeServiceAsync employeeService
            , IRegionServiceAsync regionService)
        {
            employeeServiceAsync = employeeService;
            regionServiceAsync = regionService;
        }

        public async Task<IActionResult> Table()
        {
            var collection = await employeeServiceAsync.GetAllAsync();
            if (collection != null)
            {
                return View(collection);
            }
            List<EmployeeResponseModel> emptyList = new List<EmployeeResponseModel>();
            return View(emptyList);
        }

        public async Task<IActionResult> Card()
        {
            var collection = await employeeServiceAsync.GetAllAsync();
            if (collection != null)
            {
                return View(collection);
            }
            List<EmployeeResponseModel> emptyList = new List<EmployeeResponseModel>();
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
        public async Task<IActionResult> Create(EmployeeRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await employeeServiceAsync.AddEmployeeAsync(model);
                return Redirect("Table");
            }
            var regionCollection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(regionCollection, "Id", "Name");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.IsEdit = false;
            var editEmployee = await employeeServiceAsync.GetByIdAsync(id);
            var regionCollection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(regionCollection, "Id", "Name");
            return View(editEmployee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeRequestModel model)
        {
            ViewBag.IsEdit = false;
            if (ModelState.IsValid)
            {
                await employeeServiceAsync.UpdateEmployeeAsync(model);
                ViewBag.IsEdit = true;
            }
            var regionCollection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(regionCollection, "Id", "Name");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await employeeServiceAsync.DeleteEmployeeAsync(id);
            return RedirectToAction("Table");
        }
    }
}
