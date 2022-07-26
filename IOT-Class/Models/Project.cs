using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime BeginningDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        [ForeignKey("AppUserId")]
        public virtual AppUser AppUser { get; set; }//Öğrenci
        public double ProjectScore { get; set; }
        public string State { get; set; }//teslim etti-teslim etmedi
        public bool IsDeleted { get; set; }
    }
}
