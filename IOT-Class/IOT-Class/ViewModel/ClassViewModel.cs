using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class ClassViewModel
    {
        [Required(ErrorMessage="Lütfen Sınıf Giriniz")]
        public string className { get; set; }

        [Required(ErrorMessage ="Ders Başlama Tarihi")]
        public DateTime startDate { get; set; }

        [Required(ErrorMessage = "Ders Bitiş Tarihi")]
        public DateTime finishDate { get; set; }
        [Required(ErrorMessage = "Lütfen Toplam Mevcut  Giriniz")]
        public int  total { get; set; }
        [Required(ErrorMessage = "Lütfen Durum Giriniz")]
        public bool state { get; set; }



    }
}
