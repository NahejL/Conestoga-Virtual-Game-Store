using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Conestoga_Virtual_Game_Store.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Conestoga_Virtual_Game_Store.Models.Identity;
/*
* https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-3.0
https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-3.0
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-3.0#route-template-reference
*  *  */

namespace Conestoga_Virtual_Game_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public HomeController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        #region Index
        [Route("/")]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Register
        [HttpPost, HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> IsUrlInUse(string email)
        {
            var user = await userManager.FindByEmailAsync(email);

            return Json( user == null );
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.Email, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction();
                }

                foreach (var error in result.Errors)
                {

                }
            }
            return View();
        }
        #endregion

        #region Login
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Login model, string returnURL)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync( model.Email, model.Password, model.Remember,  false );

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnURL) && Url.IsLocalUrl(returnURL))
                        return Redirect(returnURL);
                    return RedirectToAction();
                }
            }

            return View();
        }
        #endregion

        #region Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("ARGH ERR");
        }
        #endregion
    }
}
