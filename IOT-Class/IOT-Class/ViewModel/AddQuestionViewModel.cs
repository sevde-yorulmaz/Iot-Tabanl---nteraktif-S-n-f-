using IOT_Class.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class AddQuestionViewModel
    {
        public Exam exam { get; set; }

        public List<QuestionType> QuestionType { get; set; }
        public Question questionss { get; set; }

        public string QuestionText { get; set; }

        public string Answer { get; set; }//cevap Anahtarı

        public AppUser appUser { get; set; }

        public IFormFile Image { get; set; }

        public double Score { get; set; }
       
    }
}
