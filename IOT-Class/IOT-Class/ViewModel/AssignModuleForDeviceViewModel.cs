using IOT_Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class AssignModuleForDeviceViewModel
    {
        public Device device { get; set; }
        public List<Module> modules { get; set; }
    }
}
