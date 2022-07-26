using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string ClassName { get; set; }

        [ForeignKey("SchoolId")]
        public virtual School School { get; set; }
        public int Total { get; set; }
        public DateTime LessonStartDate { get; set; }
        public DateTime LessonFinshDate { get; set; }
        public bool State { get; set; }
        public bool Delete { get; set; }
    }
}
