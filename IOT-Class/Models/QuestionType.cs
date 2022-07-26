using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.Models
{
    public class QuestionType
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
