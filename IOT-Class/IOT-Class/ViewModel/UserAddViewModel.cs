using IOT_Class.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class UserAddViewModel
    {
        [Required(ErrorMessage ="Lüften Ad Soyad Giriniz")]
        public string nameSurname { get; set; }
        [Required(ErrorMessage = "Lüften Kullanıcı Adı Giriniz")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lüften Mail Giriniz")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Lüften Telefon Giriniz")]   
        public string phone { get; set; }

        [Required(ErrorMessage = "Lüften Geçici Şifre Giriniz")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lüften Durum Giriniz")]
        public bool state { get; set; }

    }
}
