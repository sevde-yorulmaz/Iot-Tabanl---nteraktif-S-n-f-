using IOT_Class.Models;
using IOT_Class.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Controllers
{
    public class ExamController : Controller
    {
        private readonly DataContext _data;
        private readonly UserManager<AppUser> _userManager;

        public ExamController(DataContext data, UserManager<AppUser> userManager)
        {
            _data = data;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var model = _data.Exams.Where(x => x.IsDeleted == false).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddExam()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddExam(AddExamViewModel model)
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            if (ModelState.IsValid)
            {
                Exam exam = new Exam
                {
                    ExamName = model.examname,
                    AppUser = user,
                    State = true
                };
                if (exam != null)
                {
                    _data.Add(exam);
                    _data.SaveChanges();
                    return RedirectToAction("QuestionList", "Exam");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditExam(int id)
        {
            var exams = _data.Exams.Find(id);
            return View(exams);
        }
        [HttpPost]
        public IActionResult EditExam(Exam exam)
        {
            var editExam = _data.Exams.Find(exam.Id);

            try
            {
                editExam.ExamName = exam.ExamName;
                editExam.State = exam.State;

                _data.SaveChanges();

                return RedirectToAction("index", "Exam");

            }
            catch (Exception)
            {
                return RedirectToAction("EditExam", "Exam");
                throw;
            }

        }
        public IActionResult QuestionList()
        {
            var question = _data.Questions.Where(x => x.IsDeleted == false).ToList();
            return View(question);
        }
        public IActionResult GetExam(int id)
        {
            var question = _data.Questions.Where(x => x.IsDeleted == false && x.Exam.Id == id).ToList();
            return View(question);
        }
        [HttpGet]
        public IActionResult AddQType()
        {
            //var model = _data.QuestionTypes.Where(x => x.IsDeleted == false).ToList();
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
                    State = true

                };
                if (model != null)
                {
                    _data.Add(model);
                    _data.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            return View(p);


        }

        [HttpGet]
        public async Task<IActionResult> AddQuestion(int id)
        {
            var qExam = _data.Exams.FirstOrDefault(x => x.Id == id);
            List<QuestionType> qType = _data.QuestionTypes.Where(x => x.IsDeleted == false && x.State == true).ToList();
            AddQuestionViewModel model = new AddQuestionViewModel();
            model.exam = qExam;
            model.QuestionType = qType;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddQuestion(AddQuestionViewModel model)
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);
            var qExam = _data.Exams.Where(x => x.Id == model.exam.Id).FirstOrDefault();
            var quesT = await _data.QuestionTypes.FindAsync(model.questionss.QuestionType.Id);
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

            _data.Add(questions);
            _data.SaveChanges();

            return RedirectToAction("QuestionList","Exam");
        }

        [HttpGet]
        public IActionResult EditQuestion(int id)
        {
            var questions = _data.Questions.Find(id);
            return View(questions);

        }

        [HttpPost]
        public IActionResult EditQuestion(Question question)
        {
            var editquestions = _data.Questions.Find(question.Id);

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
            var qDelete = _data.Questions.Find(id);
            qDelete.IsDeleted = true;

            _data.SaveChanges();
            return RedirectToAction("QuestionList", "Exam");
        }
        public IActionResult DeleteExam(int id)
        {
            var eDelete = _data.Exams.Find(id);
            eDelete.IsDeleted = true;

            _data.SaveChanges();
            return RedirectToAction("index", "Exam");
        }
    }
}
