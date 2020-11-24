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
    public class OrderController : Controller
    {
        private readonly ICartService _cartService;
        public OrderController(ICartService cartService)
        {
            _cartService = cartService;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                int? UserId = HttpContext.Session.GetInt32("UserId");
                if (UserId != null && UserId != 0)
                {
                    CartListViewModel data = await this._cartService.GetAllCartItem(UserId);
                    if (data != null)
                        return View(data);
                }
                return RedirectToAction("LogIn", "Account");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}