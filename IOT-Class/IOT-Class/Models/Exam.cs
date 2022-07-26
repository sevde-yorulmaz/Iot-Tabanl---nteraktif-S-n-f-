using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public string ExamName { get; set; }

       [ForeignKey("AppUserId")]
        public virtual AppUser AppUser { get; set; }//sınavı hazırlayan hoca
        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
