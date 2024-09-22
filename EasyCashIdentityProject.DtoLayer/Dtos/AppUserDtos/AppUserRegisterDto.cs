using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        //bu şekilde kullanımı vardır 
        //[Required(ErrorMessage ="Ad alanı zorunludur ")]
        //[Display(Name="isim")]
        //[MaxLength(30,ErrorMessage ="en fazla 30 karakter giriniz")]
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        
    }
}
