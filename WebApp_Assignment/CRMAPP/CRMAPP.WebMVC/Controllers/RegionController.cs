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
    }
}
