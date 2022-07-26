using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ExamId")]
        public virtual Exam Exam { get; set; }

        [ForeignKey("QuestionTypeId")]
        public virtual QuestionType QuestionType { get; set; }

        public string  QuestionText { get; set; }

        public string Answer { get; set; }//cevap Anahtarı
        public string Options { get; set; }//Şıklar

        [ForeignKey("AppUserId")]
        public virtual AppUser AppUser { get; set; }

        public string Image { get; set; }

        public double Score { get; set; }
        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
