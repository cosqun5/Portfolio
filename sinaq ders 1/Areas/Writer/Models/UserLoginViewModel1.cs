using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sinaq_ders_1.Areas.Writer.Models
{
    public class UserLoginViewModel1
    {
        [Display(Name = "Kullanici Adi")]
        [Required(ErrorMessage = "Kullanici Adini daxil edin")]
        public string UserName { get; set; }
        [Display(Name = "Şifrə")]
        [Required(ErrorMessage = "Şifrəni daxil edin")]
        public string Password { get; set; }
    }
}
