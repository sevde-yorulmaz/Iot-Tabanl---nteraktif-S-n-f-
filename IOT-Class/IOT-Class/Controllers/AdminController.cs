using IOT_Class.Models;
using IOT_Class.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Controllers
{
    
    [Authorize]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly DataContext _data;
        private readonly SignInManager<AppUser> _signInManager;

        public AdminController(UserManager<AppUser> userManager, DataContext data, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _data = data;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index(/*HttpContext context*/)//Admin indexi gösterir Dashboard
        {
            //var user = await _userManager.GetUserAsync(HttpContext.User);
            return View();
        }
        
        [HttpGet]
        public async Task<IActionResult> TeacherList()//öğretmen Listesi
        {

            //var teacher = _userManager.Users;
            //var users = await (from user in _data.Users join userRole in _data.UserRoles on user.Id equals userRole.UserId join role in _data.Roles on userRole.RoleId equals role.Id where role.Name == "Teacher" select user).ToListAsync();
            var users = await _userManager.GetUsersInRoleAsync("Teacher");//öğretmen rolüne ait kişilerin listesi
            var schools = await _data.Schools.ToListAsync();
            var classes = await _data.Classes.ToListAsync();
            var device = await _data.Devices.ToListAsync();


            GetTeacherAndStudentViewModel viewModel = new GetTeacherAndStudentViewModel { 
            
                  users=users.ToList(),
                  schools=schools,
                  classes=classes,
                  devices=device
            
            };

         
            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> GetUserList()//Tüm kullanıcı Listesi******Kullanıcılar listesinde hata var
        {
            var users = await _userManager.Users.ToListAsync(); ;
            var schools = await _data.Schools.ToListAsync();
            var classes = await _data.Classes.ToListAsync();
            var device = await _data.Devices.ToListAsync();

            GetUserListViewModel getUserList = new GetUserListViewModel()
            {
                user = users,
                school=schools,
                classe=classes, 
                device=device
                
            };
            return View(getUserList);
        }
        [HttpGet]
        public async Task<IActionResult> StudentList()//öğrenci listesi
        {
            var users = await _userManager.GetUsersInRoleAsync("Student");//öğrenci rolüne ait kişilerin listesi
            var schools = await _data.Schools.ToListAsync();
            var classes = await _data.Classes.ToListAsync();
            var device = await _data.Devices.ToListAsync();

            GetTeacherAndStudentViewModel viewModel = new GetTeacherAndStudentViewModel
            {

                users = users.ToList(),
                schools = schools,
                classes = classes,
                devices=device
                

            };
            return View(viewModel);         
        }

        [HttpGet]
        public IActionResult AddUser()//Yeni kullanıcı ekleme
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(UserAddViewModel userAdd)//öğretmen-öğrenci ekleme
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    NameSurname = userAdd.nameSurname,
                    UserName = userAdd.username,
                    PhoneNumber = userAdd.phone,
                    Email = userAdd.mail,
                    RegistrationDate=DateTime.Now,
                    State = true
                };
                var result = await _userManager.CreateAsync(user, userAdd.password);

                if (result.Succeeded)
                {
                    return RedirectToAction("UserRoleList", "AdminRole");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

            }
            return View(userAdd);
        }
        [HttpGet]
        public IActionResult UpdateUser(int id)//Kullanıcı Bilgileri Güncelleme İşlemi
        {
            var values = _userManager.Users.FirstOrDefault(x => x.Id == id);
            UpdateUserViewModel updateUser = new UpdateUserViewModel
            {
                 Id = values.Id,
                 nameSurname=values.NameSurname,
                 phone=values.PhoneNumber,
                 username=values.UserName,
                 mail=values.Email,
                 state=values.State
            };
            return View(updateUser);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(UpdateUserViewModel updateUser)//Kullanıcı Bilgileri Güncelleme İşlemi
        {
            var values =_userManager.Users.Where(x => x.Id == updateUser.Id).FirstOrDefault();
            values.NameSurname = updateUser.nameSurname;
            values.UserName = updateUser.username;
            values.PhoneNumber = updateUser.phone;
            values.Email = updateUser.mail;
            values.State = updateUser.state;
            var result = await _userManager.UpdateAsync(values);
            
            if (result.Succeeded)
            {
                _data.SaveChanges();
                return RedirectToAction("GetUserList", "Admin");
            }
            return View();
        }
        public async Task<IActionResult> DeleteUser(int id)//Kullanıcı silme aslında silinme durumunu true ya çekme
        {
            //var values = _userManager.Users.FirstOrDefault(x => x.Id == id);
            //var result = await _userManager.DeleteAsync(values);//Databaseden direk kullanıcıyı siler tekrar geri alınamaz
            //if (result.Succeeded)
            //{
            //    return RedirectToAction("GetUserList", "Admin");
            //}

            var user = _data.Users.Find(id);
            user.IsDeleted = true;
            return RedirectToAction("GetUserList", "Admin");
        }
        [HttpGet]
        public async Task<IActionResult> AssignSchoolForUser(int id)//kullanıcıya okul-sınıf atama
        {
            var user = _userManager.Users.Where(x => x.Id == id).FirstOrDefault();
            List<School> schools = _data.Schools.Where(x => x.State == true && x.IsDeleted == false).ToList();
            List<Class> classes = _data.Classes.Where(x => x.State == true && x.IsDeleted == false).ToList();
            AssignSchoolViewModel model = new AssignSchoolViewModel();
            model.schools = schools;
            model.appUser = user;
            model.classes = classes;
                     
            return View(model);       
        }

        [HttpPost]
        public async Task<IActionResult> AssignSchoolForUser(AssignSchoolViewModel viewModel)//kullanıcıya okul-sınıf atama
        {
            var schooladd = _userManager.Users.FirstOrDefault(x => x.Id == viewModel.appUser.Id);
            var school = await _data.Schools.FindAsync(viewModel.appUser.School.Id);
            var classes = await _data.Classes.FindAsync(viewModel.appUser.Class.Id);
            schooladd.School = school;
            schooladd.Class = classes;
           
            var result = await _userManager.UpdateAsync(schooladd);
                if (result.Succeeded)
                {
                    return RedirectToAction("GetUserList", "Admin");
                }
               
            return View(viewModel);         
        }
        [HttpGet]
        public async Task<IActionResult> AssignDeviceForUser(int id)//kullanıcıya cihaz atama
        {
            var deviceadd = _userManager.Users.Where(x => x.Id == id).FirstOrDefault();
            List<Device> devices = _data.Devices.Where(x => x.State == true &&x.IsDeleted==false).ToList();
            AssignDeviceViewModel assignDevice = new AssignDeviceViewModel {
                user = deviceadd,
                devices = devices
            };
            return View(assignDevice);
        }
        [HttpPost]
        public async Task<IActionResult> AssignDeviceForUser(AssignDeviceViewModel assign)
        {
            var assigndevice = _userManager.Users.FirstOrDefault(x => x.Id == assign.user.Id);
            var device = await _data.Devices.FindAsync(assign.user.Device.Id);
            assigndevice.Device = device;
            var result = await _userManager.UpdateAsync(assigndevice);
            if (result.Succeeded)
            {
                return RedirectToAction("GetUserList", "Admin");
            }
            return View(assign);
        }

        public async Task<IActionResult> Logout()//Kullanıcı çıkış işlemi
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
       
        
       
    }
}
