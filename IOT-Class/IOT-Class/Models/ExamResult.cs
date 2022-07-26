using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Models
{
    public class ExamResult
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AppUserId")]
        public virtual AppUser AppUser { get; set; }//öğretmen
        public double Exam1 { get; set; }
        public double Exam2 { get; set; }
        public double AverageExam { get; set; }
        public string State { get; set; }//geçti-geçmedi
        public bool IsDeleted { get; set; }
    }
}
