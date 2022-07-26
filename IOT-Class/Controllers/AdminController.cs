using iot_Class.Models;
using iot_Class.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly DataContext _db;

        public AdminController(UserManager<AppUser> userManager, DataContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> TeacherList()
        {
            //var roles = _roleManager.Roles.ToList();

            //AppUser teacher = new AppUser();
            //teacher.Id = (int)TempData["UserId"];


            //foreach (var item in roles)
            //{
            //    if (item.Id==2)
            //    {
            //        var user = _userManager.Users.FirstOrDefault(x => x.Id == teacher.Id);
            //        teacher = user;
            //    }

            //}
            var teacher = _userManager.Users;
            var userrole = await (from user in _db.Users join userRole in _db.UserRoles on user.Id equals userRole.UserId join role in _db.Roles on userRole.RoleId equals role.Id where role.Name == "Teacher" select user).ToListAsync();


            return View(userrole);

        }

        public async Task<IActionResult> GetAllUserList()
        {
            var users = await _userManager.Users.Where(x=>x.Delete==false).ToListAsync();
            return View(users);
        }
        public async Task<IActionResult> StudentList()
        {
            var users = await _userManager.GetUsersInRoleAsync("Student");
            return View(users);
        }


        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddUser(UserAddViewModel useradd)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    NameSurname = useradd.nameSurname,
                    UserName = useradd.userName,
                    PhoneNumber = useradd.phone,
                    Email = useradd.email,
                    RegistirationDate=DateTime.Now,
                    State = true,
                };
                var result = await _userManager.CreateAsync(user, useradd.password);

                if (result.Succeeded)
                {
                    return RedirectToAction("UserRoleList", "AdminRole");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);//ilk değer key değeri boş verildi

                    }
                }

            }
            return View(useradd);
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _userManager.Users.FirstOrDefault(x => x.Delete == false && x.Id == id);
            EditUserViewModel model = new EditUserViewModel
            {
                nameSurname = values.NameSurname,
                userName = values.UserName,
                phone=values.PhoneNumber,
                email=values.Email,
                state=values.State,
            };

            return View(model);
        }
        [HttpPost]
        public async Task< IActionResult> EditUser(EditUserViewModel user)
        {
            var values = _userManager.Users.Where(x => x.Delete == false && x.Id == user.Id ).FirstOrDefault();

            values.NameSurname = user.nameSurname;
            values.UserName = user.userName;
            values.PhoneNumber = user.phone;
            values.Email = user.email;
            values.State = user.state;

            var result = await _userManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("GetAllUserList");
            }
            return View(user);
        }

        public async Task< IActionResult> DeleteUser(int id)
        {
            var model = _db.Users.Find(id);
            model.Delete = true;
            _db.SaveChanges();
            //var model = _userManager.Users.FirstOrDefault(x=>x.Id==id);
            //var result = await _userManager.DeleteAsync(model);
            //if (result.Succeeded)
            //{
            //    return RedirectToAction("GetAllUserList", "Admin");

            //}

            return RedirectToAction("GetAllUserList", "Admin");
        }

    }
   
}
