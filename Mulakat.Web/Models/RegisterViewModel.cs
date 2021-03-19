using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mulakat.Web.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen email adresinizi giriniz!")]
        [EmailAddress(ErrorMessage = "Email adresinizi uygun formatta değil!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifreniz")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Şifre tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor!")]
        public string ConfirmPassword { get; set; }
    }
}
