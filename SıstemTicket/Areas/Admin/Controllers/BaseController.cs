using SıstemTicket.Areas.Admin.Models.Attr;
using SıstemTicket.Models.Baglanti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SıstemTicket.Areas.Admin.Controllers
{
    [LoginControl]
    public class BaseController : Controller
    {
        // GET: Admin/Base

        public Contextim DB;


        public BaseController()
        {
            DB = new Contextim();
        }

        protected override void Dispose(bool disposing)
        {
            DB.Dispose();
        }
    }
}