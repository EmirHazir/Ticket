using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SıstemTicket.Models.ENTITY
{
    public class Birimler 
    {
        [Key, ForeignKey("UnvanID")]
        public int ID { get; set; }

        private DateTime _TarihEkle = DateTime.Now;
        public DateTime EklenmeTarihi { get { return _TarihEkle; } set { _TarihEkle = value; } }

        private bool _IsDeleted = true;
        public bool IsDeleted { get { return _IsDeleted; } set { _IsDeleted = value; } }

        public DateTime? SilinmeTarihi { get; set; }



        [Required]
        public string BirimAdi { get; set; }
        public string BirimAciklamasi { get; set; }
        
        public Unvan UnvanID { get; set; }


    }
}