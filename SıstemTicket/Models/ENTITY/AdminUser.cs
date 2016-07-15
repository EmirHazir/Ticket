using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SıstemTicket.Models.ENTITY
{
    public class AdminUser 
    {
        [Key]
        public int ID { get; set; }

        private DateTime _TarihEkle = DateTime.Now;
        public DateTime EklenmeTarihi { get { return _TarihEkle; } set { _TarihEkle = value; } }

        private bool _IsDeleted = true;
        public bool IsDeleted { get { return _IsDeleted; } set { _IsDeleted = value; } }

        public DateTime SilinmeTarihi { get; set; }



        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        public string Sifre { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        [StringLength(30)]
        public string Adi { get; set; }
        [Required]
        [StringLength(30)]
        public string Soyadi { get; set; }


        public int BirimID { get; set; }
        public int UnvanID { get; set; }


        [ForeignKey("UnvanID")]
        public virtual Unvan Unvanlar { get; set; }

        [ForeignKey("BirimID")]
        public virtual Birimler Birimler { get; set; }








    }
}