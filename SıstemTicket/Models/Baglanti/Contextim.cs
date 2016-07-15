using SıstemTicket.Models.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SıstemTicket.Models.Baglanti
{
    public class Contextim : DbContext
    {
        public Contextim()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-NUT70R9\\SQLEXPRESS;Database=TICKETDATA;UID=sa;PWD=123";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // bunu kullanmazsak model isimleri s takısı ile olusuyor
        }

        public DbSet<AdminUser> Adminler { get; set; } // Adminler entityde kullanacagımız yapı
        public DbSet<Birimler> Birimler { get; set; }
        public DbSet<Unvan> Unvanlar { get; set; }

        public DbSet<Areas.Admin.Models.DTO.BirimVM> BirimVMs { get; set; }
    }
}