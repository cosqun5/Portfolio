using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sinaq_ders_1.Areas.Writer.Models
{
    public class UserRegistrViewModel
    {
        [Required(ErrorMessage = "Lutfen  Adinizi Girin")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Lutfen Soyadinizi  Girin")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Lutfen Kullanici Adini Girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lutfen Resim Deyeri yoluna Girin")]
        public string ImageUrl { get; set; }



        [Required(ErrorMessage = "Lutfen Şifreyi Girin")]
        public string Password { get; set; }



        [Required(ErrorMessage = "Lutfen Şifreyi Tekrar Girin")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu deyil")]
        public string ConfirmPassword { get; set; }



        [Required(ErrorMessage = "Lutfen Mail Girin")]
        public string Mail { get; set; }
    }
}
