using IOT_Class.Models;
using IOT_Class.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly DataContext _data;

        public HomeController(UserManager<AppUser> userManager, DataContext data)
        {
            _userManager = userManager;
            _data = data;
        }

        [HttpGet]
        public async  Task<IActionResult> UserProfileEdit()//Giriş yapan kişinin kendi profilini görüp düzenlemesi
        {
            AppUser users = await _userManager.GetUserAsync(HttpContext.User);
            var schools = await _data.Schools.ToListAsync();
            var classes = await _data.Classes.ToListAsync();
            var devices = await _data.Devices.ToListAsync();
            InformationUser getUserList = new InformationUser()
            {
                user = users,
                schools = schools,
                classes = classes,
                devices = devices
            };
            return View(getUserList);
           
        }
        [HttpPost]
        public async Task<IActionResult> UserProfileEdit(InformationUser user)
        {
            var values = _userManager.Users.Where(x => x.Id == user.user.Id).FirstOrDefault();
            values.NameSurname = user.user.NameSurname;
            values.UserName = user.user.UserName;
            values.PhoneNumber = user.user.PhoneNumber;            
            values.Email = user.user.Email;
            
            var result = await _userManager.UpdateAsync(values);

            if (result.Succeeded)
            {
                _data.SaveChanges();
                return RedirectToAction("UserProfileEdit", "Home");
            }
            return View();

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
