using IOT_Class.Models;
using IOT_Class.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSingUpViewModel userSingUp)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = userSingUp.Email,
                    NameSurname = userSingUp.NameSurname,
                    UserName = userSingUp.UserName


                };
                var result = await _userManager.CreateAsync(user, userSingUp.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");//Logindeki index e git  demek
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);//ilk değer key değeri boş verildi
                    }
                }
            }
            return View(userSingUp);
        }
    }
}
