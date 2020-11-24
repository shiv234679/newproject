using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.ProductCategories;
using Services.Products;
using ViewModels.Models;

namespace RGS.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IProductCatService _productCatService;
        private readonly IProductService _productService;
        public DashboardController(IProductCatService productCatService, IProductService productService)
        {
            _productCatService = productCatService;
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                DashboardListViewModel response = new DashboardListViewModel();
                ProductCatListViewModel abc = await this._productCatService.GetAllProductCategory();
                ProductListViewModel xyz = await this._productService.GetAllProduct();
                response.productCatViewModels = abc.productCatViewModels;
                response.productViewModels = xyz.productViewModels;
                if (response.productCatViewModels.Count > 0 || response.productViewModels.Count > 0)
                    return View(response);
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult Contact()
        {
            return View();
        } 
        public async Task<IActionResult> SearchProduct(string text)
        {
            try
            {
                ProductListViewModel response = await this._productService.GetProductByCategoryId(text);
                if (response != null)
                    return View(response);
                return RedirectToAction("Index", "Dashboard");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}