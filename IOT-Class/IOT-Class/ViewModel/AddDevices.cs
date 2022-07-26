using IOT_Class.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class AddDevices
    {
        [Required(ErrorMessage = "Lüften Cihaz Adı Giriniz")]
        public string deviceName { get; set; }

        [Required(ErrorMessage = "Lüften Cihaz Açıklaması Giriniz")]
        public string description { get; set; }

        [Required(ErrorMessage = "Lüften Cihazın Modulleri Seçiniz")]
        
        public bool state { get; set; }

    }
}
