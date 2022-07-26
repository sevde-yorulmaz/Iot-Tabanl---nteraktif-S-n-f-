using IOT_Class.Models;
using IOT_Class.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Controllers
{
    public class SchoolController : Controller
    {
        private readonly DataContext _data;

        public SchoolController(DataContext data)
        {
            _data = data;
        }

        public IActionResult Index()
        {
            var model = _data.Schools.Where(x=>x.IsDeleted==false).ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddSchool()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSchool(SchoolViewModel school)
        {
            if (ModelState.IsValid)
            {
                School schools = new School
                {
                    Name = school.name,
                    Email = school.email,
                    Phone = school.phone,
                    Addresss = school.address,
                    State = true

                };
                if (schools != null)
                {
                    _data.Schools.Add(schools);
                    _data.SaveChanges();
                    return RedirectToAction("Index", "School");
                }

            }
            return View(school);

        }
        public IActionResult DeleteSchool(int id)
        {
            var schoolvalue = _data.Schools.Find(id);
            schoolvalue.IsDeleted = true;
            schoolvalue.State = false;
            _data.SaveChanges();
            return RedirectToAction("Index", "School");
        }
        [HttpGet]
        public IActionResult EditSchool(int id)
        {
            var schoolvalue = _data.Schools.Find(id);
            return View(schoolvalue);
        }
        [HttpPost]
   
        public IActionResult EditSchool(School school)
        {
            var schoolEdit = _data.Schools.Find(school.Id);
            try
            {
                schoolEdit.Name = school.Name;
                schoolEdit.Addresss = school.Addresss;
                schoolEdit.Phone = school.Phone;
                schoolEdit.Email = school.Email;
                schoolEdit.State = school.State;
                
                _data.SaveChanges();
                return RedirectToAction("Index", "School");

            }
            catch 
            {
                return RedirectToAction("EditSchool", "School");

            }
        }
    }
}
