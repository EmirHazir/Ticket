using SıstemTicket.Areas.Admin.Models.Attr; // kontrolu kullanmak için
using SıstemTicket.Models.Baglanti;
using SıstemTicket.Models.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SıstemTicket.Areas.Admin.Controllers
{
    [LoginControl] // bu clası yazdım (Attr)
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            Contextim DB = new Contextim();
            string email = HttpContext.User.Identity.Name;
            AdminUser adminUser = DB.Adminler.FirstOrDefault(x => x.Email == email);
            string name = adminUser.Adi;
            string surname = adminUser.Soyadi;
            return View();
        }
    }
}