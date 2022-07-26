using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int Total { get; set; }//sınıf mevcudu
        [ForeignKey("SchoolId")]
        public virtual School School { get; set; }
        public DateTime LessonStartDate { get; set; }
        public DateTime LessonFinishDate { get; set; }
        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
