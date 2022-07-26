using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.Models
{
    public class AppUser:IdentityUser<int>
    {
        public string NameSurname { get; set; }

        [ForeignKey("DeviceId")]
        public virtual Device Device { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }

        [ForeignKey("SchoolId")]
        public virtual School School { get; set; }
        public DateTime RegistirationDate { get; set; }
        public bool State { get; set; }
        public bool Delete { get; set; }
    }
}
