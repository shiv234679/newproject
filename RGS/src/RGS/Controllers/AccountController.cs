using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Accounts;
using Services.Carts;
using ViewModels.Models;

namespace RGS.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly ICartService _cartService;
        public AccountController(IAccountService accountService, ICartService cartService)
        {
            _accountService = accountService;
            _cartService = cartService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(AccountReqViewModel model)
        {
            try
            {
                AccountViewModel response = await this._accountService.LogIn(model);
                if (response.UserId != 0)
                {
                    HttpContext.Session.SetInt32("UserId", (int)response.UserId);
                    HttpContext.Session.SetString("UserType", response.UserType.ToString());
                    HttpContext.Session.SetString("UserName", response.UserName);
                    HttpContext.Session.SetString("EmailId", response.EmailId);
                    HttpContext.Session.SetString("MobileNumber", response.MobileNumber);
                    int result = await this._cartService.GetCartItemCount(response.UserId);
                    HttpContext.Session.SetInt32("ItemCount", result);
                    return RedirectToAction("Index", "Dashboard");
                }
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(AccountReqViewModel model)
        {
            try
            {
                int num = await this._accountService.SignUp(model);
                if (num == 1)
                {
                    return RedirectToAction("LogIn");
                }
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}