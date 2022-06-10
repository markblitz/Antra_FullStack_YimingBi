using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServiceAsync employeeServiceAsync;
        public EmployeeController(IEmployeeServiceAsync employeeService)
        {
            employeeServiceAsync = employeeService;
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
            return View(model);
        }
    }
}
