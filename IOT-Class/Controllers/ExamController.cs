using iot_Class.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using iot_Class.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Collections.Generic;

namespace iot_Class.Controllers
{
    public class ExamController : Controller
    {
        private readonly DataContext _db;
        private readonly UserManager<AppUser> _userManager;

        public ExamController(DataContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public IActionResult Index()
        {            
            var model = _db.Exams.Where(x=>x.IsDeleted==false).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddExam()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> AddExam( AddExamViewModel model)
        {
            AppUser user =await _userManager.GetUserAsync(HttpContext.User);
            if (ModelState.IsValid)
            {
                Exam exam = new Exam
                {
                    ExamName = model.examname,
                    AppUser = user,
                    State = true
                };
                if (exam!=null)
                {
                    _db.Add(exam);
                    _db.SaveChanges();
                    return RedirectToAction("QuestionList", "Exam");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditExam(int id)
        {
            var exams = _db.Exams.Find(id);
            return View(exams);
        }
        [HttpPost]
        public IActionResult EditExam(Exam exam)
        {
            var editExam = _db.Exams.Find(exam.Id);

            try
            {
                editExam.ExamName = exam.ExamName;
                editExam.State = exam.State;

                _db.SaveChanges();

                return RedirectToAction("index","Exam");

            }
            catch (Exception)
            {
                return RedirectToAction("EditExam", "Exam");
                throw;
            }
           
        }
        public IActionResult QuestionList()
        {
            var question = _db.Questions.Where(x => x.IsDeleted == false).ToList();
            return View(question);
        }
        public IActionResult GetExam(int id)
        {
            var question = _db.Questions.Where(x => x.IsDeleted == false && x.Exam.Id==id).ToList();
            return View(question);
        }
        [HttpGet]
        public IActionResult AddQType()
        {
            //var model = _db.QuestionTypes.Where(x => x.IsDeleted == false).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddQType(AddQuestionTypeViewModel p)
        {
            if (ModelState.IsValid)
            {
                QuestionType model = new QuestionType
                {
                    TypeName = p.qType,
                    State=true

                };
                if (model!=null)
                {
                    _db.Add(model);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            return View(p);


        }

        [HttpGet]
        public async Task<IActionResult> AddQuestion(int id)
        {
            var qExam= _db.Exams.Where(x => x.Id==id).FirstOrDefault();
            List<QuestionType> qType = _db.QuestionTypes.Where(x => x.IsDeleted == false &&  x.State==true).ToList();
            AddQuestionViewModel model = new AddQuestionViewModel();
            model.exam = qExam;
            model.QuestionType = qType;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddQuestion(AddQuestionViewModel model)
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            var qExam =_db.Exams.Where(x=>x.Id==model.exam.Id).FirstOrDefault();
            var quesT = _db.QuestionTypes.Find(model.questionss.QuestionType.Id);
            Question questions = new Question();
            if (model.Image != null)
            {
                var extension = Path.GetExtension(model.Image.FileName);//uzantı--resmin türü IFormFile Olmalı
                var newimagename = Guid.NewGuid() + extension;//benzersiz resim adı
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newimagename);//Konum Değeri
                var stream = new FileStream(location, FileMode.Create);//Akış--ilgili lokasyona oluşturma hazırlığı yapıldı
                model.Image.CopyToAsync(stream);//Akışta gönderilecek resmin yolunu kopyaladık
                questions.Image = newimagename;


            }

            questions.QuestionText = model.QuestionText;
            questions.Score = model.Score;
            questions.Answer = model.Answer;
            questions.AppUser = user;
            questions.Exam = qExam;
            questions.QuestionType = quesT;
            questions.State = true;

            _db.Add(questions);
            _db.SaveChanges();

            return View();
        }

        [HttpGet]
        public IActionResult EditQuestion(int id)
        {
            var questions = _db.Questions.Find(id);
            return View(questions);

        }

        [HttpPost]
        public IActionResult EditQuestion(Question question)
        {
            var editquestions = _db.Questions.Find(question.Id);

            try
            {
                editquestions.Image = question.Image;
                editquestions.QuestionText = question.QuestionText;
                editquestions.QuestionType = question.QuestionType;
                editquestions.Score = question.Score;

                return RedirectToAction("QuestionList", "Exam");


            }
            catch (Exception)
            {
                return RedirectToAction("QuestionList", "Exam");
                throw;
            }

        }

        public IActionResult DeleteQuestion(int id)
        {
            var qDelete = _db.Questions.Find(id);
            qDelete.IsDeleted = true;

            _db.SaveChanges();
            return RedirectToAction("QuestionList", "Exam");
        }
        public IActionResult DeleteExam(int id)
        {
            var eDelete = _db.Exams.Find(id);
            eDelete.IsDeleted = true;

            _db.SaveChanges();
            return RedirectToAction("index", "Exam");
        }
    }
}
