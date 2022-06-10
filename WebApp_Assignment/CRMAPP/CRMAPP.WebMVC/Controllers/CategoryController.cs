using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRMApp.WebMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServiceAsync categoryServiceAsync;
        public CategoryController(ICategoryServiceAsync categoryService)
        {
            categoryServiceAsync = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var collection = await categoryServiceAsync.GetAllAsync();
            if (collection != null)
            {
                return View(collection);
            }
            List<CategoryModel> emptyList = new List<CategoryModel>();
            return View(emptyList);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryModel model)
        {
            if (ModelState.IsValid)
            {
                await categoryServiceAsync.AddCategoryAsync(model);
                return Redirect("Index");
            }
            return View(model);
        }
    }
}
