using IOT_Class.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class AssignSchoolViewModel
    {
        public AppUser appUser { get; set; }
        public List<School> schools { get; set; }//Açılır kutudaki her bir elemanı barındırır
        public List<Class> classes { get; set; }


    }
}
