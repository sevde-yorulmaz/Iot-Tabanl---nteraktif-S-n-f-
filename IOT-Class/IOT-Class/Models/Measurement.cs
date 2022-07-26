using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Models
{
    public class Measurement
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("DeviceId")]
        public virtual Device Device { get; set; }
        [ForeignKey("ModuleId")]
        public virtual Module Module { get; set; }
        public DateTime MeasurementDate { get; set; }
        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
