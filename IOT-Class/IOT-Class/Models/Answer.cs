using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("AppUserId")]
        public virtual AppUser AppUser { get; set; }//öğrenci yanıtları

        [ForeignKey("QuestionTypeId")]
        public virtual QuestionType QuestionType { get; set; }

        [ForeignKey("ExamId")]
        public virtual Exam Exam { get; set; }

        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
