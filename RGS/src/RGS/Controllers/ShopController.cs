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
    public class ShopController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductCatService _productCatService;
        public ShopController(IProductService productService, IProductCatService productCatService)
        {
            _productService = productService;
            _productCatService = productCatService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ShopDetails(long Id = 0, long Cid = 0)
        {
            try
            {
                ProductListViewModel response = await this._productService.GetProductByCategoryId(Cid);
                if (response?.productViewModels?.Count > 0)
                {
                    TempData["Id"] = Id;
                    return View(response);
                }
                return RedirectToAction("ProductDetails", "Shop");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IActionResult> ProductDetails(long id = 0)
        {
            try
            {
                ProductListViewModel response = await this._productService.GetProductByCategoryId(id);
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