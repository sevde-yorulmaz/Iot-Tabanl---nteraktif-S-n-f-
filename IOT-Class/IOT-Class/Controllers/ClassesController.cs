using IOT_Class.Models;
using IOT_Class.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Controllers
{
    public class ClassesController : Controller
    {
        private readonly DataContext _data;

        public ClassesController(DataContext data)
        {
            _data = data;
        }
        public IActionResult Index()
        {
            var model = _data.Classes.Where(x => x.IsDeleted == false).ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddClass()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddClass(ClassViewModel classView)
        {
            if (ModelState.IsValid)
            {
                Class classes = new Class
                {
                    ClassName = classView.className,
                    LessonStartDate=classView.startDate,
                    LessonFinishDate=classView.finishDate,
                    Total=classView.total,
                    State=true,


                };
                if (classes != null)
                {
                    _data.Classes.Add(classes);
                    _data.SaveChanges();
                    return RedirectToAction("Index", "Classes");
                }

            }
            return View(classView);

        }
        public IActionResult DeleteClass(int id)
        {
            var Classvalue = _data.Classes.Find(id);
            Classvalue.IsDeleted = true;
            Classvalue.State = false;
            _data.SaveChanges();
            return RedirectToAction("Index", "Classes");
        }
    }
}
