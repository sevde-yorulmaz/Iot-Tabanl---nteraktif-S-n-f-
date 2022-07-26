using IOT_Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class GetTeacherAndStudentViewModel
    {
        public List<AppUser> users { get; set; }
        public List<Class> classes { get; set; }
        public List<School> schools { get; set; }
        public List<Device> devices { get; set; }

    }
}
