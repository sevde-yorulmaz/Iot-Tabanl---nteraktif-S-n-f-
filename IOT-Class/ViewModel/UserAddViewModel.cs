using iot_Class.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Class.ViewModel
{
    public class UserAddViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string nameSurname { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen Email Adresini Giriniz")]
        public string email { get; set; }

        [Required(ErrorMessage = "Lütfen Telefon Numaranızı Giriniz")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Lütfen Geçici Şifre Giriniz")]
        public string password { get; set; }
        public bool state { get; set; }
    }
}
