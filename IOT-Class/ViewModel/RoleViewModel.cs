using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.ViewModel
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lütfen Görev Adı Giriniz.")]
        public string Name { get; set; }
    }
}
