using SıstemTicket.Areas.Admin.Models.DTO;
using SıstemTicket.Models.Baglanti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SıstemTicket.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private Contextim DB = new Contextim();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (DB.Adminler.Any(x=>x.Email == model.Email && x.Sifre == model.Sifre && x.IsDeleted==false))
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }    
        }


        public ActionResult Cikis()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}