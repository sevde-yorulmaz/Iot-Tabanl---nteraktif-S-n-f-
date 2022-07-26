using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_Class.ViewModel
{
    public class AddModule
    {
        [Required(ErrorMessage="Lütfen Modül Adı Giriniz")]
        public string moduleName { get; set; }
        [Required(ErrorMessage = "Lütfen Dijital Minimum Değerini Giriniz")]

        public int digitalMinValue { get; set; }
        [Required(ErrorMessage = "Lütfen Dijital Maksimum Değerini Giriniz")]

        public int digitalMaxValue { get; set; }
        [Required(ErrorMessage = "Lütfen Analog Minimum Değerini Giriniz")]

        public int analogMinValue { get; set; }
        [Required(ErrorMessage = "Lütfen Dijital Maksimum Değerini Giriniz")]

        public int analogMaxValue { get; set; }
        [Required(ErrorMessage = "Lütfen Modül Durumu Giriniz")]

        public bool state { get; set; }
    }
}
