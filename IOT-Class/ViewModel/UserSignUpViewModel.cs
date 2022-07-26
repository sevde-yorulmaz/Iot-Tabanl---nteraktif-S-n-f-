using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace iot_Class.ViewModel
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage = "Ad Soyad Giriniz")]
        public string NameSurname { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }

        [Display(Name = "Şİfre")]
        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }

        [Display(Name = "Şİfre")]
        [Compare("Password",ErrorMessage = "Şifreler Uyuşmuyor!!!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Lütfen Email Giriniz")]
        public string Email { get; set; }

    }
}
