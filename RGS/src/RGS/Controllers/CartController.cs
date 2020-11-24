using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Carts;
using ViewModels.Models;

namespace RGS.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AddCart(CartViewModel model)
        {
            try
            {
                int? UserId = HttpContext.Session.GetInt32("UserId");
                if (UserId != null && UserId != 0)
                {
                    model.UserId = (long)UserId;
                    int num = await this._cartService.AddCart(model);
                    if (num == 1)
                    {
                        TempData["Success"] = 200;
                        int result = await this._cartService.GetCartItemCount((int)model.UserId);
                        HttpContext.Session.SetInt32("ItemCount", result);
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
                TempData["Success"] = 404;
                return RedirectToAction("LogIn", "Account");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}