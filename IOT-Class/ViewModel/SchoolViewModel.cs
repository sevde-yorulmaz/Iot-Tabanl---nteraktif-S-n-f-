
using System.ComponentModel.DataAnnotations;


namespace iot_Class.ViewModel
{
    public class SchoolViewModel
    {
        [Required(ErrorMessage = "Lütfen Rol Adı Giriniz.")]
        public string name { get; set; }


        [Required(ErrorMessage = "Lütfen Okul Adresi Giriniz.")]
        public string address { get; set; }


        [Required(ErrorMessage = "Lütfen Okul Telefonu Giriniz.")]
        public string phone { get; set; }


        [Required(ErrorMessage = "Lütfen Okul Mail Adresi Giriniz.")]
        public string email { get; set; }


        [Required(ErrorMessage = "Lütfen Okul Durumu Giriniz.")]
        public bool state { get; set; }
    }
}
