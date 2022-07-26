using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.Models
{
    public class AppUser:IdentityUser<int>
    {
        public string NameSurname { get; set; }

        [ForeignKey("DeviceId")]
        public virtual Device Device { get; set; }

        [ForeignKey("SchoolId")]
        public virtual School School { get; set; }
        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }
      
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }
        public bool IsDeleted { get; set; }
    }
}
