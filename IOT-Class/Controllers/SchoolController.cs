using iot_Class.Models;
using iot_Class.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ILogger<SchoolController> _logger;
        private readonly DataContext _db;

        public SchoolController(ILogger<SchoolController> logger, DataContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var model = _db.Schools.Where(x=> x.IsDeleted==false).ToList();
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
                    Email=school.email,
                    Addresss=school.address,
                    Phone=school.phone,
                    State=true

                };

                if (schools!=null)
                {
                    _db.Schools.Add(schools);
                    _db.SaveChanges();

                    return RedirectToAction("index", "School");
                }
            }
            return View(school);
        }

        [HttpGet]
        public IActionResult EditSchool(int id)
        {
            var schoolvalue = _db.Schools.Find(id);
            return View(schoolvalue);
        }
        [HttpPost]
        public IActionResult EditSchool(School school)
        {
            var editschool = _db.Schools.Find(school.Id);

            try
            {
                editschool.Name = school.Name;
                editschool.Addresss = school.Addresss;
                editschool.Email = school.Email;
                editschool.Phone = school.Phone;
                editschool.State = school.State;

                _db.SaveChanges();

                return RedirectToAction("index", "School");

            }
            catch (Exception)
            {
                return RedirectToAction("EditSchool", "School");

                throw;
            }

        }

        public IActionResult DeleteSchool(int id)
        {
            var editschool = _db.Schools.Find(id);
            editschool.IsDeleted = true;
            _db.SaveChanges();

            return RedirectToAction("index", "School");
        }
    }
}
