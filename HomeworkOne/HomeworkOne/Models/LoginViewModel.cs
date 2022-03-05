using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOne.Models
{
    public class LoginViewModel
    {
        [Display(Order = 1, Name = "Ad")]
        [Required(ErrorMessage = "Ad Alanı Boş Geçilemez!")]
        [RegularExpression("^([a-zA-Z])+$", ErrorMessage = "Adınız sadece harflerden oluşmalıdır.")]
        public string FirstName { get; set; }

        [Display(Order = 2, Name = "Soyad")]
        [Required(ErrorMessage = "Soyad Alanı Boş Geçilemez!")]
        [RegularExpression("^([a-zA-Z])+$", ErrorMessage = "Soyadınız sadece harflerden oluşmalıdır.")]
        public string LastName { get; set; }

        [Display(Order = 3, Name = "Email Adresi")]
        [Required(ErrorMessage = "Email Adresi Alanı Boş Geçilemez!")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\.[A-Za-z0-9-]{2,}$", ErrorMessage = "Lütfen geçerli bir email adresi giriniz.")]
        public string Email { get; set; }

        [Display(Order = 4, Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Alanı Boş Geçilemez!")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Şifreniz en az 8 karakterden oluşmalıdır ve en az 1 büyük harf, 1 özel karakter, 1 rakamdan oluşmalıdır.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
