using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Models
{
    public class School
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addresss { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
