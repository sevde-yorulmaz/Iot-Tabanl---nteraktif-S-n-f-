using IOT_Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class AssignDeviceViewModel
    {
        public AppUser user { get; set; }
        public List<Device> devices { get; set; }
    }
}
