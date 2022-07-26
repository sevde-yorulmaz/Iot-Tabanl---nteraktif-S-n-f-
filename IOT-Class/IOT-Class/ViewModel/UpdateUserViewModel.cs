using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class UpdateUserViewModel
    {
        public int Id { get; set; }
        public string nameSurname { get; set; }
        public string username { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
        public bool state { get; set; }
    }
}
