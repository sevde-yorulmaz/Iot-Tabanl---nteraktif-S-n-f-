using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.Models
{
    public class Device
    {
        [Key]
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public DateTime UsingDate { get; set; }
        public string Description { get; set; }
        [ForeignKey("ModuleId")]
        public virtual Module Module { get; set; }
        public bool State { get; set; }
        public bool Delete { get; set; }
    }
}
