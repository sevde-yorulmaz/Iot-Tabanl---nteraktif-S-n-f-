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
 
    //[Authorize(Roles = "Principal")]//Sadece Müdür Rol İşlemlerini Gerçekleştirebilir
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public AdminRoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()//Rol listesini getircek
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model)//Rol Ekleme
        {
            if (ModelState.IsValid)
            {
                AppRole role = new AppRole { 
                 Name=model.name
                          
                };
                var result = await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","AdminRole");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult UpdateRole(int id)//Rol Güncelleme İşlemi
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            RoleUpdateViewModel roleUpdateView = new RoleUpdateViewModel
            {
                Id=values.Id,
                name=values.Name
            };
            return View(roleUpdateView);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateViewModel roleUpdate)//Rol Güncelleme İşlemi
        {
            var values = _roleManager.Roles.Where(x => x.Id == roleUpdate.Id).FirstOrDefault();
            values.Name = roleUpdate.name;
            var result = await _roleManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "AdminRole");
            }
            return View();
        }
        public IActionResult UserRoleList()//User Listesini getircek
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var result = await _roleManager.DeleteAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","AdminRole");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)//Userdaki Rolleri getirir
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = _roleManager.Roles.ToList();

            TempData["UserId"] = user.Id;

            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> model = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel m = new RoleAssignViewModel();
                m.RoleID = item.Id;
                m.Name = item.Name;
                m.Exists = userRoles.Contains(item.Name);
                model.Add(m);
                
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> roleAssigns)//Rol Atama İşlemi
        {
            var userid =(int) TempData["UserId"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);
            foreach (var item in roleAssigns)
            {
                if (item.Exists)
                {
                    await _userManager.AddToRoleAsync(user, item.Name);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.Name);
                }
            }
            return RedirectToAction("UserRoleList");
        }

    }
}
