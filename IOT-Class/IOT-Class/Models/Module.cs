using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public int DigitalMinValue { get; set; }
        public int DigitalMaxValue { get; set; }
        public int AnalogMinValue { get; set; }
        public int AnalogMaxValue { get; set; }
        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
