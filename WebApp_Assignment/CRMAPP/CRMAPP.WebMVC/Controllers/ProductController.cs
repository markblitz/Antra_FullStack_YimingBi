using CRMApp.Core.Contract.Service;
using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRMApp.WebMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServiceAsync productServiceAsync;
        private readonly ICategoryServiceAsync categoryServiceAsync;
        private readonly ISupplierServiceAsync supplierServiceAsync;
        public ProductController(IProductServiceAsync productService,
            ICategoryServiceAsync categoryService,
            ISupplierServiceAsync supplierService)
        {
            productServiceAsync = productService;
            categoryServiceAsync = categoryService;
            supplierServiceAsync = supplierService;
        }

        public async Task<IActionResult> Index()
        {
            var collection = await productServiceAsync.GetAllAsync();
            if (collection != null)
            {
                return View(collection);
            }
            List<ProductResponseModel> emptyList = new List<ProductResponseModel>();
            return View(emptyList);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categoryCollection = await categoryServiceAsync.GetAllAsync();
            var supplierCollection = await supplierServiceAsync.GetAllAsync();
            ViewBag.Categories = new SelectList(categoryCollection, "Id", "Name");
            ViewBag.Suppliers = new SelectList(supplierCollection, "Id", "CompanyName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await productServiceAsync.AddProductAsync(model);
                return Redirect("Index");
            }
            var categoryCollection = await categoryServiceAsync.GetAllAsync();
            var supplierCollection = await supplierServiceAsync.GetAllAsync();
            ViewBag.Categories = new SelectList(categoryCollection, "Id", "Name");
            ViewBag.Suppliers = new SelectList(supplierCollection, "Id", "CompanyName");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.IsEdit = false;
            var editProduct = await productServiceAsync.GetByIdAsync(id);
            var categoryCollection = await categoryServiceAsync.GetAllAsync();
            var supplierCollection = await supplierServiceAsync.GetAllAsync();
            ViewBag.Categories = new SelectList(categoryCollection, "Id", "Name");
            ViewBag.Suppliers = new SelectList(supplierCollection, "Id", "CompanyName");
            return View(editProduct);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductRequestModel model)
        {
            ViewBag.IsEdit = false;
            if (ModelState.IsValid)
            {
                await productServiceAsync.UpdateProductAsync(model);
                ViewBag.IsEdit = true;
            }
            var categoryCollection = await categoryServiceAsync.GetAllAsync();
            var supplierCollection = await supplierServiceAsync.GetAllAsync();
            ViewBag.Categories = new SelectList(categoryCollection, "Id", "Name");
            ViewBag.Suppliers = new SelectList(supplierCollection, "Id", "CompanyName");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await productServiceAsync.DeleteProductAsync(id);
            return RedirectToAction("Index");
        }
    }
}
