using IOT_Class.Models;
using IOT_Class.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewComponents
{
    public class AdminMenuViewComponent:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminMenuViewComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()//Giriş yapan kişinin bilgileri görünsün
        {           
            AppUser users = await _userManager.GetUserAsync(HttpContext.User);         
            return View("Default.cshtml",users);
        }
    }
}
