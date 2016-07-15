using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SıstemTicket.Areas.Admin.Models.DTO
{
    public class BirimVM : BaseVM
    {
        [Required(ErrorMessage ="Lütfen Birim adı giriniz")]
        [Display(Name ="Birim Adı")]
        public string BirimAdi { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklama giriniz")]
        [StringLength(150)]
        [Display(Name = "Birim Açıklaması")]
        public string Aciklamasi { get; set; }
    }
}