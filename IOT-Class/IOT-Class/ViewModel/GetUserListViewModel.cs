using IOT_Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class GetUserListViewModel
    {
        public List<AppUser> user { get; set; }
        public List<Class> classe { get; set; }
        public List<School> school { get; set; }
        public List<Device> device { get; set; }
    }
}
