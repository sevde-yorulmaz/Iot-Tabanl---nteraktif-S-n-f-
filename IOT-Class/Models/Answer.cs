using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("AppUserId")]
        public virtual AppUser AppUser { get; set; }//Öğrenci

        [ForeignKey("QuestionTypeId")]
        public virtual QuestionType QuestionType { get; set; }

        [ForeignKey("ExamId")]
        public virtual Exam Exam { get; set; }

        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
