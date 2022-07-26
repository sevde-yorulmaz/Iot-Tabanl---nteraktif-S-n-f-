using iot_Class.Models;
using iot_Class.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.Controllers
{
    [AllowAnonymous]
    public class Login : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public Login(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel user)
        {
            if (ModelState.IsValid)
            {
            var result = await _signInManager.PasswordSignInAsync(user.username, user.password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");

                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }

            return View(user);
        }
    }
}
