using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Products;
using Services.ProductCategories;
using ViewModels.Models;

namespace RGS.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductCatService _productCatService;
        private readonly IProductService _productService;
        public AdminController(IProductCatService productCatService, IProductService productService)
        {
            _productCatService = productCatService;
            _productService = productService;
        }

        #region Product
        public async Task<IActionResult> Index()
        {
            try
            {
                ProductListViewModel response = await this._productService.GetAllProduct();
                if (response != null)
                    return View(response);
                return View();
            }
            catch (Exception)
            {
                throw;
            };
        }
        public async Task<IActionResult> AddProduct()
        {
            try
            {
                ProductCatListViewModel response = await this._productCatService.GetAllProductCategory();
                if (response != null)
                    return View(response);
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductRequestViewModel model)
        {
            try
            {
                var response = await this._productService.AddProduct(model);
                if (response)
                    return RedirectToAction("Index");
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IActionResult> EditProduct(long Id)
        {
            try
            {
                ProductCatListViewModel response = await this._productCatService.GetAllProductCategory();
                ProductViewModel data = await this._productService.GetProductById(Id);
                if (data != null)
                {
                    data.productCatViewModels = response.productCatViewModels;
                    return View(data);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductRequestViewModel model)
        {
            try
            {
                bool response = await this._productService.UpdateProduct(model);
                if (response)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Product Category
        public async Task<IActionResult> Home()
        {
            try
            {
                ProductCatListViewModel response = await this._productCatService.GetAllProductCategory();
                if (response != null)
                    return View(response);
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult AddProductCategory()
        {
            try
            {
                //bool response = await this._productCatService.AddProductCategory();
                //if (response)
                //{
                //    return RedirectToAction("Index");
                //}
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProductCategory(ProductCatReqViewModel model)
        {
            try
            {
                bool response = await this._productCatService.AddProductCategory(model);
                if (response)
                    return RedirectToAction("Home");
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IActionResult> EditProductCategory(long Id)
        {
            try
            {
                ProductCatViewModel data = await this._productCatService.GetProductCategoryById(Id);
                if (data != null)
                {
                    return View(data);
                }
                return RedirectToAction("Home");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditProductCategory(ProductCatReqViewModel model)
        {
            try
            {
                bool response = await this._productCatService.UpdateProductCategory(model);
                if (response)
                {
                    return RedirectToAction("Home");
                }
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}