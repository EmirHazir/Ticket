using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SıstemTicket.Areas.Admin.Models.DTO
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Boş geçilemez")]
        [EmailAddress(ErrorMessage ="Düzgün bir email adresi gir")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Sifreni gir")]
        public string Sifre { get; set; }
    }
}