using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class UserSingUpViewModel
    {
        [Display(Name="Mail Adresiniz")]
        [Required(ErrorMessage ="Lütfen Mail Giriniz.")]
        public string Email { get; set; }



        [Display(Name = "Ad Soyad İsminiz")]
        [Required(ErrorMessage = "Lütfen Kullanıcı İsminizi Giriniz.")]
        public string NameSurname { get; set; }

        [Display(Name = "Kullanıcı Adınız")]
        [Required(ErrorMessage = "Lütfen Kullanıcı İsminizi Giriniz.")]
        public string UserName { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen Şifre Giriniz.")]
        public string Password { get; set; }


        [Display(Name ="Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
