using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebMVC.Controllers
{
    public class RegionController : Controller
    {
        private readonly IRegionServiceAsync regionServiceAsync;
        public RegionController(IRegionServiceAsync regionService)
        {
            regionServiceAsync = regionService;
        }

        public async Task<IActionResult> Index()
        {
            var collection = await regionServiceAsync.GetAllAsync();
            if (collection != null)
            {
                return View(collection);
            }
            List<RegionModel> emplyList = new List<RegionModel>();
            return View(emplyList);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegionModel model)
        {
            if (ModelState.IsValid)
            {
                await regionServiceAsync.AddRegionAsync(model);
                return Redirect("Index");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.IsEdit = false;
            var editRegion = await regionServiceAsync.GetByIdAsync(id);
            return View(editRegion);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RegionModel model)
        {
            ViewBag.IsEdit = false;
            if (ModelState.IsValid)
            {
                await regionServiceAsync.UpdateRegionAsync(model);
                ViewBag.IsEdit = true;
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await regionServiceAsync.DeleteRegionAsync(id);
            return RedirectToAction("Index");
        }
    }
}
